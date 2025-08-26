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
            <!doctype html>
            <html lang=""en"">
            <head>
                <meta charset=""utf-8"">
                <meta name=""viewport"" content=""width=device-width,initial-scale=1"">
                <title>New Contact Message</title>
                <style>
                body {{ margin:0; padding:0; background:#f5f7fb; font-family:Arial, sans-serif; }}
                .container {{ max-width:600px; margin:20px auto; background:#fff; padding:20px; border-radius:8px; }}
                h2 {{ margin:0 0 12px; font-size:20px; color:#111827; }}
                .info {{ margin:4px 0; font-size:14px; }}
                .msg {{ margin-top:12px; padding:12px; background:#f9fafb; border:1px solid #e5e7eb; border-radius:6px; font-size:14px; white-space:pre-wrap; }}
                a.btn {{ display:inline-block; margin-top:16px; padding:10px 16px; background:#3b82f6; color:#fff; text-decoration:none; border-radius:6px; font-weight:bold; font-size:14px; }}
                </style>
            </head>
            <body>
                <div class=""container"">
                <h2>📩 New Contact Message</h2>
                <p class=""info""><strong>From:</strong> {emailDto.From}</p>
                <div class=""msg"">{emailDto.Body}</div>
                <a class=""btn"">
                    Reply
                </a>
                </div>
            </body>
            </html>
            ";

            email.Body = new TextPart(TextFormat.Html) { Text = body };

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_options.SMTPHost, _options.SMTPPort, SecureSocketOptions.StartTls);

            await smtp.AuthenticateAsync(_options.SMTPUsername, _options.SMTPPassword);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }

        public async Task SendEmailToJobOwner(string toEmail, string applyingUserName, string jobName)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("freejob682@gmail.com"));
            email.To.Add(MailboxAddress.Parse(toEmail));
            email.Subject = "Apply for job";

            var body = @$"
            <!DOCTYPE html>
            <html lang=""en"">
              <head>
                <meta charset=""UTF-8"" />
                <title>New Job Application</title>
              </head>
              <body style=""margin:0; padding:20px; font-family: Arial, sans-serif; background-color:#f6f6f6; color:#333;"">
    
                <div style=""max-width:600px; margin:0 auto; background:#ffffff; border-radius:8px; padding:24px;"">
      
                  <!-- Header -->
                  <h2 style=""color:#4F46E5; margin-top:0; margin-bottom:16px;"">New Job Application</h2>
      
                  <!-- Body -->
                  <p style=""font-size:16px; line-height:1.5; margin:0 0 16px;"">
                    Dear Owner,
                  </p>
      
                  <p style=""font-size:16px; line-height:1.5; margin:0 0 16px;"">
                    We wanted to let you know that <strong>{applyingUserName}</strong> has just applied for the {jobName}.
                  </p>
      
                  <p style=""font-size:16px; line-height:1.5; margin:0 0 16px;"">
                    Please log in to your account to review the application.
                  </p>
      
                  <!-- Footer -->
                  <p style=""font-size:12px; line-height:1.5; color:#777; margin-top:32px; border-top:1px solid #eee; padding-top:16px;"">
                    You are receiving this email because you have a job posting on our platform.<br />
                    © 2025 FreeJob
                  </p>
      
                </div>
    
              </body>
            </html>
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
