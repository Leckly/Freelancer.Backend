using Freelancer.Backend.Business.Dto;

namespace Freelancer.Backend.Business.Interfaces
{
    public interface IUserService
    {
        Task SignUpAsync(RegisterDTO registerDTO);
        Task<UserDTO> SignInAsync(LoginDTO loginDTO);
        Task SignOutAsync();
    }
}
