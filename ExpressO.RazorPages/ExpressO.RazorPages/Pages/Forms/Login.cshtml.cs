using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressO.RazorPages.Models;
using ExpressO.RazorPages.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExpressO.Pages.Forms
{
    public class LoginModel : PageModel
    {
        private ILoginRepository _loginRepository;

        public LoginModel(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        [BindProperty]
        public List<Login> LoginList { get; set; }

        public void OnGet()
        {
            LoginList = _loginRepository.GetList();
        }

        [BindProperty]
        public Login Login { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Login l = _loginRepository.Validate(Login.UserName, Login.Password);

                return RedirectToPage("/About");
            }

            return RedirectToPage("/Error");
        }

        public IActionResult OnPostSignup()
        {
            return RedirectToPage("Signup");
        }

        //------------------------------------------------------------------------------------------------------------
        //TODO figure out this line of code to take user input and search database for matching username and password.
        //(LoginList.SingleOrDefault(x => x.UserName == Login.UserName)
        //------------------------------------------------------------------------------------------------------------
    }
}