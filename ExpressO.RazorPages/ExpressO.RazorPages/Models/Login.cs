using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressO.RazorPages.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Must be username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Must be password")]
        public string Password { get; set; }
    }
}
