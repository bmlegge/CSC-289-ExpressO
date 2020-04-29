using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeProjectWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoffeeProjectWebApp
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginInformation Login { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            // TODO Create Database Library to Save Model to Database

            return RedirectToPage("/Index", new { UserName = "Coffee Finder " + Login.UserName  });
        }
    }
}