using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Index()
        {
            return View(await _basket.GetAllByUserID("13"));
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
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserID,ProductID,Quantity")] Basket basket, int quantity)
        {
            if (id != basket.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _basket.UpdateBasket(basket, quantity);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BasketExists(basket.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(basket);
        }

        // GET: Baskets/Delete/5
        // Removes a basket item from cart.
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Basket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _basket.DeleteBasket(id);
            return RedirectToAction(nameof(Index));
        }

        //Checks for existence
        private bool BasketExists(int id)
        {
            return _basket.GetOneBasket(id) != null;
        }
    }
}