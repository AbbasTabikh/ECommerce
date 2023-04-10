using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.Models
{
    public  class UserMail
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Subject is necessary for us to reply faster")]
        [MinLength(6)]
        public string Subject { get; set; } = string.Empty;

        [MinLength(35 , ErrorMessage ="Message at least should be 35 characters")]
        public string Message { get; set; } = string.Empty;
    }
}
