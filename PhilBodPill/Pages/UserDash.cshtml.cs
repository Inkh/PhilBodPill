using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhilBodPill.Models;
using PhilBodPill.Models.Interfaces;

namespace PhilBodPill.Pages
{
    [Authorize]
    public class UserDashModel : PageModel
    {
        private IOrder _order;
        private SignInManager<User> _signInManager;

        public UserDashModel(IOrder order, SignInManager<User> signInManager)
        {
            _order = order;
            _signInManager = signInManager;
        }

        [BindProperty]
        public IEnumerable<PhilBodPill.Models.Order> Orders { get; set; }

        public async Task OnGet()
        {
            if (_signInManager.IsSignedIn(User))
            {
                string id = User.Claims.First(name => name.Type == "userID").Value;
                Orders = await _order.GetOrdersByUser(id);
            }
            
        }
    }
}