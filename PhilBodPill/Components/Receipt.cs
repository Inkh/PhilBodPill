using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using PhilBodPill.Models;
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
        private readonly IOrder _order;
        private IEmailSender _email;

        public Receipt(IBasket basket, IEmailSender email, IOrder order)
        {
            _basket = basket;
            _email = email;
            _order = order;
        }

        public async Task<IViewComponentResult> InvokeAsync(string uid, string email)
        {
            var baskets = await _basket.GetAllByUserID(uid);

            // Email User Reciept
            string subject = "Thanks for shopping with us. Here is your receipt.";
            string receipt = "";
            string listItems = "";
            decimal total = 0;
            foreach (var basket in baskets)
            {
                decimal subtotal = basket.Product.Price * (decimal)basket.Quantity;
                listItems += $"<li>{basket.Product.Name} x {basket.Quantity}";
                total += subtotal;
            }
            receipt = $"<h2>{subject}</h2><ul>{listItems}</ul><h4>Total: {total}</h4>";
            await _email.SendEmailAsync(email, subject, receipt);

            // Create Order
            Order newOrder = new Order();
            newOrder.UserID = uid;
            newOrder.TotalPrice = total;
            newOrder.Date = DateTime.Now;
            newOrder.Baskets = baskets.ToList();

            await _order.CreateOrder(newOrder);

            // Delete Baskets
            foreach (var basket in baskets)
            {
                await _basket.DeleteBasket(basket.ID);
            }
            return View(baskets);
        }
    }
}
