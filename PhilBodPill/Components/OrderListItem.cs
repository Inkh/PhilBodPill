using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhilBodPill.Data;
using PhilBodPill.Models;
using PhilBodPill.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Components
{
    public class OrderListItem : ViewComponent
    {
        private IOrder _order;
        private UserManager<User> _userManager;

        public OrderListItem(IOrder order, UserManager<User> userManager)
        {
            _order = order;
            _userManager = userManager;
        }

        public class ListItem
        {
            public string CustomerName;
            public DateTime OrderDate;
            public decimal OrderTotal;
        }

        public async Task<IViewComponentResult> InvokeAsync(Order order)
        {
            var user = await _userManager.FindByIdAsync(order.UserID);
            ListItem result = new ListItem
            {
                CustomerName = $"{user.FirstName} {user.LastName}",
                OrderDate = order.Date,
                OrderTotal = order.TotalPrice
            };

            return View(result);
        }
    }
}
