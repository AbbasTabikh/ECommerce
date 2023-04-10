using ECommerce.Shared.Models;
using MailKit.Net.Smtp;
using MimeKit;

namespace ECommerce.Server.Services.EmailService
{
    public class MailService : IMailService
    {
        private readonly EmailConfiguration _configuration;

        public MailService(EmailConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendMailAsync(UserMail userMail)
        {
            using (var email = new MimeMessage())
            {
                //my email 
                email.From.Add(MailboxAddress.Parse(_configuration.From));

                //my other email that i will receive the emails in
                email.To.Add(MailboxAddress.Parse(_configuration.To));
                
                email.Subject = userMail.Subject;
                email.Body = new BodyBuilder
                {
                    HtmlBody = $"<h4>username : {userMail.Name} email : {userMail.Email}</h4> <p>{userMail.Message}</p>"
                }.ToMessageBody();

                using (var smtp = new SmtpClient())
                {
                    try
                    {
                        await smtp.ConnectAsync(_configuration.SmtpServer, _configuration.Port, true);
                        await smtp.AuthenticateAsync(_configuration.UserName, _configuration.Password);
                        await smtp.SendAsync(email);
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        await smtp.DisconnectAsync(true);
                        smtp.Dispose();
                    }                    
                }
            }
        }
    }
}
