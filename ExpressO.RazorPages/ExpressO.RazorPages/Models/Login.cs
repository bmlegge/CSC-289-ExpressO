using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressO.RazorPages.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Must enter a username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Must enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Must enter a password")]
        [Compare("Login.Password", ErrorMessage = "Passwords must match!")]
        public string PasswordConfirmation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Admin { get; set; }
    }
}
