namespace ECommerce.Server.Services.EmailService
{
    public class EmailConfiguration
    {
        public string From { get; set; } = default!;
        public string To { get; set; } = default!;
        public string SmtpServer { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public int Port { get; set; } 
    }
}
