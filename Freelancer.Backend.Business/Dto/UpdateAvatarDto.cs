using Microsoft.AspNetCore.Http;

namespace Freelancer.Backend.Business.Dto;

public class UpdateAvatarDto
{
    public IFormFile File { get; set; }
}
