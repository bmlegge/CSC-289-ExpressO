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
    public class MenuModel : PageModel
    {
        private ICoffeeShopRepository _coffeeShopRepository;

        public MenuModel(ICoffeeShopRepository coffeeShopRepository)
        {
            _coffeeShopRepository = coffeeShopRepository;
        }

        [BindProperty]
        public List<CoffeeShop> MenuList { get; set; }

        [BindProperty]
        public CoffeeShop Menu { get; set; }

        public void OnGet(int id)
        {
            Menu = _coffeeShopRepository.GetShop(id);
        }
    }
}