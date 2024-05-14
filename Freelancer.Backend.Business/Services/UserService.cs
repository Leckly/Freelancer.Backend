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
                throw new EntityNotFoundApiException();
            }


            var userExists = _passwordHasher.VerifyHashedPassword(default, user.PasswordHash, loginDTO.Password);
            if (userExists != PasswordVerificationResult.Success)
            {
                throw new EntityNotFoundApiException();
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
                Description = registerDTO.Description
            };

            var tags = new List<UserTag>();
            foreach (var tag in registerDTO.Tags)
            {
                tags.Add(new UserTag()
                {
                    Name = tag,
                    User = newUser
                });
            }

            newUser.UserTags = tags;

            var photo = new Photo()
            {
                Name = "",
                ContentType = registerDTO.File.ContentType
            };

            newUser.Photo = photo;

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
            else if (registerDTO.UserType == UserType.Employeer)
            {
                var role = await _roleRepository.GetByFilterAsync(x => x.Name == "Employeer");
                newUser.Role = role;
            }

            var addedUser = await _userRepository.AddAsync(newUser);

            var again = await _userRepository.GetByEmailWithRoleAsync(x => x.Id == addedUser.Id);

            again.Photo.Name = $"{addedUser.Id}.{again.Photo.ContentType.Remove(0, 6)}";

            await _userRepository.UpdateAsync(addedUser.Id, again);

            var buffer = new byte[registerDTO.File.Length];

            using (var content = new MemoryStream(buffer))
            {
                await registerDTO.File.CopyToAsync(content);
                content.Position = 0;

                await _photoContentRepository.SaveUserPhotoAsync(again.Photo.Name, content);
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
            var oldTags = user.UserTags.ToList();

            user.FirstName = userDTO.FirstName;
            user.LastName = userDTO.LastName;
            user.Address = userDTO.Address;
            user.CompanyName = userDTO.CompanyName;
            user.Nip = userDTO.Nip;
            user.Krs = userDTO.Krs;
            user.Description = userDTO.Description;

            var newTags = new List<UserTag>();

            foreach (var tag in userDTO.Tags)
            {
                newTags.Add(new UserTag()
                {
                    Name = tag,
                    UserId = id,
                    User = user,
                });
            }
            user.UserTags = newTags;

            await _userRepository.UpdateAsync(id, user, oldTags);
        }
    }
}
