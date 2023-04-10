using ECommerce.Shared.Models;

namespace ECommerce.Server.Services.EmailService
{
    public interface IMailService
    {
        Task SendMailAsync(UserMail userMail);
    }
}
