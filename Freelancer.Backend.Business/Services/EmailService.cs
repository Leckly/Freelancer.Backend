using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace Freelancer.Backend.Business.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmail(EmailDto emailDto)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(""));
            email.To.Add(MailboxAddress.Parse(""));
            email.Subject = emailDto.Subject;
            email.Body = new TextPart(TextFormat.Html) { Text = emailDto.Body };

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync("", 0, SecureSocketOptions.StartTls);

            await smtp.AuthenticateAsync("", "");
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
