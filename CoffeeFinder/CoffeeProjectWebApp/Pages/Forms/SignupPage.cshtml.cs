using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoffeeProjectWebApp.Models;
namespace CoffeeProjectWebApp
{
    public class SignupPageModel : PageModel
    {

        [BindProperty]
        public SignUpInformation CreateUser { get; set; }
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

            return RedirectToPage("/Index");
        }
    }
}