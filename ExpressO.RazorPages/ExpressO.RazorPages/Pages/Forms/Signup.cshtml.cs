using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ExpressO.RazorPages.Models;

namespace ExpressO.RazorPages
{
    public class SignupModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty]
        public Login Login { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // TODO Place users into the database

            return RedirectToPage("/Index");
        }
    }
}