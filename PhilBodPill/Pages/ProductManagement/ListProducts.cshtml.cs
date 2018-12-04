using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhilBodPill.Models.Interfaces;

namespace PhilBodPill.Pages.ProductManagement
{
    [Authorize(Policy = "AdminOnly")]
    public class ListProductsModel : PageModel
    {
        private IInventory _inventory;

        public ListProductsModel(IInventory inventory)
        {
            _inventory = inventory;
        }

        [BindProperty]
        public IEnumerable<PhilBodPill.Models.Product> Products { get; set; }

        public async Task OnGet()
        {
            Products = await _inventory.GetProducts();
        }
    }
}