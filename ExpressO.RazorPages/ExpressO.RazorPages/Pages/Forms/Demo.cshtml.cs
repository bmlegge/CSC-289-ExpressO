using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressO.RazorPages.Models;
using ExpressO.RazorPages.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExpressO.RazorPages.Pages.Forms
{
    public class DemoModel : PageModel
    {
        private ILoginRepository _loginRepository;

        public DemoModel(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [BindProperty]
        public List<Login> loginList { get; set; }

        public void OnGet()
        {
            loginList = _loginRepository.GetList();
        }
    }
}