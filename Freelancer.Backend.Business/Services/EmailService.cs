using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Infrastructure.Configurations;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;

namespace Freelancer.Backend.Business.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailOptions _options;

        public EmailService(IOptions<EmailOptions> options)
        {
            _options = options.Value;
        }

        public async Task SendEmail(EmailDto emailDto)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(emailDto.From));
            email.To.Add(MailboxAddress.Parse(_options.EmailTo));
            email.Subject = emailDto.Subject;

            var body = @$"
            <h1>From: {emailDto.From}</h1>
            {emailDto.Body}
            ";

            email.Body = new TextPart(TextFormat.Html) { Text = body };

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_options.SMTPHost, _options.SMTPPort, SecureSocketOptions.StartTls);

            await smtp.AuthenticateAsync(_options.SMTPUsername, _options.SMTPPassword);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
