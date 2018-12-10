using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhilBodPill.Models.Interfaces;

namespace PhilBodPill.Pages
{
    [Authorize(Policy = "AdminOnly")]
    public class AdminDashModel : PageModel
    {
        private IOrder _order;

        public AdminDashModel(IOrder order)
        {
            _order = order;
        }

        [BindProperty]
        public IEnumerable<PhilBodPill.Models.Order> Orders { get; set; }

        public async Task OnGet()
        {
            Orders = await _order.GetOrders();
        }
    }
}