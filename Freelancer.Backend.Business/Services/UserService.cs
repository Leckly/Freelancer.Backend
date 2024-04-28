using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Domain.Entities;
using Freelancer.Backend.Domain.Enums;
using Freelancer.Backend.Domain.Exceptions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Freelancer.Backend.Business.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly HttpContext _httpContext;
        public UserService(UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContext = httpContextAccessor.HttpContext;
        }

        public async Task<UserDTO> SignInAsync(LoginDTO loginDTO)
        {
            if (loginDTO == null)
            {
                throw new ValidationApiException();
            }

            var user = await _userManager.FindByEmailAsync(loginDTO.Email);
            if (user == null)
            {
                throw new EntityNotFoundApiException();
            }

            var userExists = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if (!userExists)
            {
                throw new EntityNotFoundApiException();
            }

            var role = await _userManager.GetRolesAsync(user);

            await AddCookies(user, role.First());

            return new UserDTO { };
        }

        public async Task SignUpAsync(RegisterDTO registerDTO)
        {
            if (registerDTO == null)
            {
                throw new ValidationApiException();
            }

            var newUser = new ApplicationUser()
            {
                Email = registerDTO.Email,
                PasswordHash = registerDTO.Password,
                Address = registerDTO.Address,
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                CompanyName = registerDTO.CompanyName,
                KRS = registerDTO.KRS,
                NIP = registerDTO.NIP,
                Country = registerDTO.Country,
                Tags = registerDTO.Tags,
                Description = registerDTO.Description
            };

            var user = await _userManager.FindByEmailAsync(newUser.Email);
            if (user is not null)
            {
                throw new UserExistApiException();
            }

            var createUser = await _userManager.CreateAsync(newUser, newUser.PasswordHash);
            if (!createUser.Succeeded)
            {
                throw new ApiBaseException();
            }

            if(registerDTO.UserType == UserType.Employee)
            {
                await _userManager.AddToRoleAsync(newUser, "Employee");
            }
            else if (registerDTO.UserType == UserType.Employeer)
            {
                await _userManager.AddToRoleAsync(newUser, "Employeer");
            }
        }

        public async Task SignOutAsync()
        {
            await _httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        private async Task AddCookies(ApplicationUser user, string role)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, role)
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
    }
}
