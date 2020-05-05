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
    public class CoffeeShopsModel : PageModel
    {
        private ICoffeeShopRepository _coffeeShopRepository;

        public CoffeeShopsModel(ICoffeeShopRepository coffeeShopRepository)
        {
            _coffeeShopRepository = coffeeShopRepository;
        }

        [BindProperty]
        public List<CoffeeShop> CoffeeShopList { get; set; }

        [BindProperty]
        public CoffeeShop CoffeeShops { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public void OnGet()
        {
            CoffeeShopList = _coffeeShopRepository.Search(SearchTerm);
        }
    }
}