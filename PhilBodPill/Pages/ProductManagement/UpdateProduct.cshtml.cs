using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhilBodPill.Models;
using PhilBodPill.Models.Interfaces;

namespace PhilBodPill.Pages.ProductManagement
{
    [Authorize(Policy = "AdminOnly")]
    public class UpdateProductModel : PageModel
    {
        private IInventory _inventory;

        public UpdateProductModel(IInventory inventory)
        {
            _inventory = inventory;
        }

        [BindProperty]
        public PhilBodPill.Models.Product Product { get; set; }

        public async Task OnGet(int id)
        {
            Product = await _inventory.GetProduct(id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _inventory.UpdateProduct(Product);

            return RedirectToPage("./AdminDash");
        }
    }
}