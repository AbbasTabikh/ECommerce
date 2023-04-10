using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using ECommerce.Shared.Models;
using ECommerce.Server.Services;
using ECommerce.Server.Services.EmailService;

namespace ECommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly IMailService _mailService;

        public EmailsController(IMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost("sendmail")]
        public async Task<IActionResult> SendEmail(UserMail userMail)
        {
            try
            {
                await _mailService.SendMailAsync(userMail);
                return Ok();
            }catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
