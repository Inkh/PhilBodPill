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
    public class ProductsController : Controller
    {
        private readonly IInventory _inventory;
        private readonly IBasket _basket;

        public ProductsController(IInventory inventory, IBasket basket)
        {
            _inventory = inventory;
            _basket = basket;
        }

        //GET: Products
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _inventory.GetProducts());
        }


        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _inventory.GetProduct(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/CreateBasket
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateBasket([Bind("ID,ProductID,UserID,Quantity")]Basket basket)
        {
            if (ModelState.IsValid)
            {
                await _basket.CreateBasket(basket);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        //Checks for existence
        private bool ProductExists(int id)
        {
            return _inventory.GetProduct(id) != null;
        }
    }
}