using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhilBodPill.Models;
using PhilBodPill.Models.Interfaces;

namespace PhilBodPill.Controllers
{
    public class BasketController : Controller
    {
        private readonly IInventory _inventory;
        private readonly IBasket _basket;

        public BasketController(IInventory inventory, IBasket basket)
        {
            _inventory = inventory;
            _basket = basket;
        }

        //GET: Baskets by UserID
        //Grabs the shopping cart for current logged in user.
        [Authorize(Policy = "NoChetsAllowed")]
        public IActionResult Index()
        {
            return View();
        }

        // GET: Baskets/Edit/5
        // Allows the editing of product quantity.
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basket = await _basket.GetOneBasket(id);
            if (basket == null)
            {
                return NotFound();
            }
            return View(basket);
        }

        // POST: Baskets/Edit/5
        // Allows the editing of product quantity in cart.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Quantity")] int quantity)
        {
            await _basket.UpdateBasket(id, quantity);
            return RedirectToAction(nameof(Index));
        }

        // POST: Basket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _basket.DeleteBasket(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Basket/Checkout
        public IActionResult Checkout()
        {
            return View();
        }

        //Checks for existence
        private bool BasketExists(int id)
        {
            return _basket.GetOneBasket(id) != null;
        }
    }
}