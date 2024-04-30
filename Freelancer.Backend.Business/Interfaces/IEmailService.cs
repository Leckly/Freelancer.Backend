using Freelancer.Backend.Business.Dto;

namespace Freelancer.Backend.Business.Interfaces
{
    public interface IEmailService
    {
        Task SendEmail(EmailDto emailDto);
    }
}
