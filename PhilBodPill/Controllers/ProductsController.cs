﻿using System;
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
        //[Authorize(Policy = "NoChetsAllowed")]
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

        // GET: Products/Create
        [Authorize(Policy = "AdminOnly")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Image,Price,Description")]Product product)
        {
            if (ModelState.IsValid)
            {
                await _inventory.CreateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> Edit(int? id)
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

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Image,Price,Description")] Product product)
        {
            if (id != product.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _inventory.UpdateProduct(product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ID))
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
            return View(product);
        }

        // GET: Products/Delete/5
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _inventory.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: Products/CreateBasket
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateBasket([Bind("ProductID,UserID,Quantity")]Basket basket)
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