using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using System.Net.Mail;

namespace Freelancer.Backend.Business.Services
{
    public class EmailService : IEmailService, IDisposable
    {
        private readonly SmtpClient smtpClient;

        public EmailService()
        {
            smtpClient = new SmtpClient();
        }

        ~EmailService() 
        {
            Dispose();
        }

        public void Dispose()
        {
            smtpClient.Dispose();
        }

        public Task SendEmail(EmailDto emailDto)
        {
            throw new NotImplementedException();
        }
    }
}
