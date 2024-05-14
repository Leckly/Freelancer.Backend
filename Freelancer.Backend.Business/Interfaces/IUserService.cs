using Freelancer.Backend.Business.Dto;

namespace Freelancer.Backend.Business.Interfaces
{
    public record ReceivePhotoResponse(Stream content, string contentType, string name);
    public interface IUserService
    {
        Task SignUpAsync(RegisterDTO registerDTO);
        Task<UserDTO> SignInAsync(LoginDTO loginDTO);
        Task SignOutAsync();
        Task<ReceivePhotoResponse> DownloadPhotoAsync(int userId);
        Task UpdateAsync(UpdateUserDto userDTO, int id);
    }
}
