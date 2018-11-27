using Microsoft.AspNetCore.Mvc;
using PhilBodPill.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Components
{
    public class Receipt : ViewComponent
    {
        private readonly IBasket _basket;

        public Receipt(IBasket basket)
        {
            _basket = basket;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var baskets = await _basket.GetAllByUserID(id);
            foreach (var basket in baskets)
            {
                await _basket.DeleteBasket(basket.ID);
            }
            return View(baskets);
        }
    }
}
