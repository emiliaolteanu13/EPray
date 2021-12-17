using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EPray.Models
{
    public class RegistrationModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid Email Address!")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
