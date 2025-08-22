using AutoMapper;
using FluentValidation;
using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Domain;
using Freelancer.Backend.Domain.Enums;
using Freelancer.Backend.Domain.Exceptions;
using Freelancer.Backend.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Freelancer.Backend.Business.Services
{
    public class UserService : IUserService
    {
        private readonly HttpContext _httpContext;
        private readonly IValidator<RegisterDTO> _validator;
        private readonly IUserRepository _userRepository;
        private readonly IRepository<Role> _roleRepository;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IPhotoContentRepository _photoContentRepository;
        private readonly IMapper _mapper;

        public UserService(IHttpContextAccessor httpContextAccessor,
            IValidator<RegisterDTO> validator,
            IUserRepository userRepository,
            IRepository<Role> roleRepository,
            IPasswordHasher<User> passwordHasher,
            IPhotoContentRepository photoContentRepository,
            IMapper mapper)
        {
            _httpContext = httpContextAccessor.HttpContext;
            _validator = validator;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _passwordHasher = passwordHasher;
            _photoContentRepository = photoContentRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> SignInAsync(LoginDTO loginDTO)
        {
            if (loginDTO == null)
            {
                throw new ValidationApiException();
            }

            var user = await _userRepository.GetByEmailWithRoleAsync(x => x.Email == loginDTO.Email);
            if (user == null)
            {
                throw new UserNotFoundApiException();
            }


            var userExists = _passwordHasher.VerifyHashedPassword(default, user.PasswordHash, loginDTO.Password);
            if (userExists != PasswordVerificationResult.Success)
            {
                throw new UserNotFoundApiException();
            }

            await AddCookies(user);

            return _mapper.Map<UserDTO>(user);
        }

        public async Task SignUpAsync(RegisterDTO registerDTO)
        {
            if (registerDTO == null)
            {
                throw new ValidationApiException();
            }

            await _validator.ValidateAndThrowAsync(registerDTO);

            var newUser = new User()
            {
                Email = registerDTO.Email,
                PasswordHash = _passwordHasher.HashPassword(default, registerDTO.Password),
                Address = registerDTO.Address,
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                CompanyName = registerDTO.CompanyName,
                Krs = registerDTO.KRS,
                Nip = registerDTO.NIP,
                Country = registerDTO.Country,
                Description = registerDTO.Description,
                Tags = registerDTO.Tags ?? Array.Empty<string>()
            };

            if (registerDTO.File is not null)
            {
                var photo = new UserPhoto()
                {
                    Name = "",
                    ContentType = registerDTO.File.ContentType
                };
                newUser.Photo = photo;
            }

            var user = await _userRepository.GetByFilterAsync(x => x.Email == newUser.Email);
            if (user is not null)
            {
                throw new UserExistApiException();
            }

            if (registerDTO.UserType == UserType.Employee)
            {
                var role = await _roleRepository.GetByFilterAsync(x => x.Name == "Employee");
                newUser.Role = role;
            }
            else if (registerDTO.UserType == UserType.Employer)
            {
                var role = await _roleRepository.GetByFilterAsync(x => x.Name == "Employer");
                newUser.Role = role;
            }

            var addedUser = await _userRepository.AddAsync(newUser);

            var again = await _userRepository.GetByEmailWithRoleAsync(x => x.Id == addedUser.Id);

            if (again.Photo is not null)
            {
                again.Photo.Name = $"{addedUser.Id}.{again.Photo.ContentType.Remove(0, 6)}";
            }

            await _userRepository.UpdateAsync(addedUser.Id, again);

            if (registerDTO.File is not null)
            {
                var buffer = new byte[registerDTO.File.Length];

                using (var content = new MemoryStream(buffer))
                {
                    await registerDTO.File.CopyToAsync(content);
                    content.Position = 0;

                    await _photoContentRepository.SaveUserPhotoAsync(again.Photo.Name, content);
                }

            }
            
        }

        public async Task SignOutAsync()
        {
            await _httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        private async Task AddCookies(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role.Name)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties()
            {
                AllowRefresh = true,
            };

            await _httpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }

        public async Task<ReceivePhotoResponse> DownloadPhotoAsync(int userId)
        {
            var user = await _userRepository.GetByEmailWithRoleAsync(x => x.Id == userId);
            if (user is null)
            {
                throw new EntityNotFoundApiException();
            }

            if (user.Photo is null)
            {
                throw new EntityNotFoundApiException();
            }

            var memoryStream = await _photoContentRepository.GetUserPhotoAsync(user.Photo.Name);
            return new ReceivePhotoResponse(memoryStream, user.Photo.ContentType, user.Photo.Name);
        }

        public async Task UpdateAsync(UpdateUserDto userDTO, int id)
        {
            var user = await _userRepository.GetByEmailWithRoleAsync(x => x.Id == id);
            if (user is null)
            {
                throw new EntityNotFoundApiException();
            }

            user.FirstName = userDTO.FirstName;
            user.LastName = userDTO.LastName;
            user.Address = userDTO.Address;
            user.CompanyName = userDTO.CompanyName;
            user.Nip = userDTO.Nip;
            user.Krs = userDTO.Krs;
            user.Description = userDTO.Description;
            user.Tags = userDTO.Tags;

            await _userRepository.UpdateAsync(id, user);
        }

        public async Task<IEnumerable<UserDTO>> GetAllAsync(int type, int skip, int take, string searchBar, string[] tags)
        {
            var users = await _userRepository.GetAllWithIncludesAsync();

            if (!searchBar.IsNullOrEmpty())
            {
                searchBar = searchBar.ToLower();
                users = users
                    .Where(x =>
                    (!string.IsNullOrEmpty(x.CompanyName) && x.CompanyName.ToLower().Contains(searchBar)) ||
                    (!string.IsNullOrEmpty(x.Description) && x.Description.ToLower().Contains(searchBar)) ||
                    (!string.IsNullOrEmpty(x.FirstName) && x.FirstName.ToLower().Contains(searchBar)) ||
                    (!string.IsNullOrEmpty(x.LastName) && x.LastName.ToLower().Contains(searchBar)));
            }

            if (tags != null && tags.Length > 0)
            {
                users = users.Where(x => tags.Select(y => y.ToLower()).Intersect(x.Tags.Select(z => z.ToLower())).Any());
            }

            var id = _httpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            if (id is null)
            {
                return users.Where(x => x.RoleId == type).Skip(skip).Take(take).Select(x => _mapper.Map<UserDTO>(x)).ToList();
            }
            return users.Where(x => x.RoleId == type && x.Id != int.Parse(id)).Skip(skip).Take(take).Select(x => _mapper.Map<UserDTO>(x)).ToList();
        }

        public async Task<UserDTO> GetAsync(int id)
        {
            var user = await _userRepository.GetByEmailWithRoleAsync(x => x.Id == id);

            if (user is null)
            {
                throw new EntityNotFoundApiException();
            }

            return _mapper.Map<UserDTO>(user);
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _userRepository.GetByFilterWithPhotoAsync(x => x.Id == id);

            if (user.Photo != null)
            {
                _photoContentRepository.DeleteUserPhotoContent(user.Photo.Name);
            }

            await _userRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserDTO>> GetTop3EmployersAsync()
        {
            var users = await _userRepository.GetAllWithRatingsAsync();

            var top3 = users
                        .Where(x => x.Role.Id == 2)
                        .OrderByDescending(x => x.Ratings != null && x.Ratings.Any()
                            ? x.Ratings.Average(r => r.Rate)
                            : 0)
                        .Take(3)
                        .ToList();
            return top3.Select(x => _mapper.Map<UserDTO>(x)).ToList();
        }

        public async Task<IEnumerable<UserDTO>> GetTop3FreelancersAsync()
        {
            var users = await _userRepository.GetAllWithRatingsAsync();

            var top3 = users
                        .Where(x => x.Role.Id == 1)
                        .OrderByDescending(x => x.Ratings != null && x.Ratings.Any()
                            ? x.Ratings.Average(r => r.Rate)
                            : 0)
                        .Take(3)
                        .ToList();
            return top3.Select(x => _mapper.Map<UserDTO>(x)).ToList();
        }

        public async Task UpdatePhotoAsync(UpdateAvatarDto updateAvatarDto, int userId)
        {
            var user = await _userRepository.GetByFilterWithPhotoAsync(x => x.Id == userId);

            if(user is null)
            {
                throw new EntityNotFoundApiException();
            }
            if (updateAvatarDto.File is not null)
            {
                if (user.Photo is null)
                {
                    user.Photo = new UserPhoto()
                    {
                        Name = $"{user.Id}.{updateAvatarDto.File.ContentType.Remove(0, 6)}",
                        ContentType = updateAvatarDto.File.ContentType
                    };
                    await _userRepository.UpdateAsync(userId, user);
                }
                else
                {
                    user.Photo.ContentType = updateAvatarDto.File.ContentType;
                }

            
                var buffer = new byte[updateAvatarDto.File.Length];

                using (var content = new MemoryStream(buffer))
                {
                    await updateAvatarDto.File.CopyToAsync(content);
                    content.Position = 0;

                    await _photoContentRepository.SaveUserPhotoAsync(user.Photo.Name, content);
                }
            }
        }
    }
}
