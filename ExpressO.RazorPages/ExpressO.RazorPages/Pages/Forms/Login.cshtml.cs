using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressO.RazorPages.Models;
using ExpressO.RazorPages.Repository;
using Microsoft.AspNetCore.Http;
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
        public List<Signup> SignupList { get; set; }

        public void OnGet()
        {
            SignupList = _loginRepository.GetList();
        }

        [TempData]
        public string Message { get; set; }
        public bool ShowMessage => !string.IsNullOrEmpty(Message);

        [BindProperty]
        public Login Login { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Login l = _loginRepository.Validate(Login.UserName, Login.Password);

                if(l != null)
                {
                    return RedirectToPage("/Forms/CoffeeShop");
                }

                return Page();
            }

            return Page();
        }

        public IActionResult OnPostSignup()
        {
            return RedirectToPage("Signup");
        }
    }
}