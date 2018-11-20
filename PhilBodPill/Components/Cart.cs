using Microsoft.AspNetCore.Mvc;
using PhilBodPill.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Components
{
    public class Cart : ViewComponent
    {
        private PhilBodPillDbContext _context;

        public Cart(PhilBodPillDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var baskets = (from bask in _context.Basket
                           where bask.UserID == id
                           select bask);

                return View(baskets);
        }

    }
}
