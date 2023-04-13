using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.Models
{
    public  class PasswordResource
    {

        [Required]
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;    
    }
}
