using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ExpressO.RazorPages.Models;
using ExpressO.RazorPages.Repository;
using ExpressO.RazorPages.Hash;

namespace ExpressO.RazorPages
{
    public class SignupModel : PageModel
    {
        ILoginRepository _loginRepository;

        public SignupModel(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [BindProperty]
        public Signup Signup { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var count = _loginRepository.Add(Signup);

                if (count > 0)
                {
                    return RedirectToPage("/Forms/Login");
                }
            }

            return Page();
        }
    }
}