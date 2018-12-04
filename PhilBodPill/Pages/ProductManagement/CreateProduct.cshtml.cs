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
    public class CreateProductModel : PageModel
    {
        private IInventory _inventory;

        public CreateProductModel(IInventory inventory)
        {
            _inventory = inventory;
        }

        [BindProperty]
        public PhilBodPill.Models.Product Product { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            await _inventory.CreateProduct(Product);

            return RedirectToPage("./AdminDash");
        }
    }
}