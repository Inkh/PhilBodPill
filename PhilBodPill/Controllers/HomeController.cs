using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhilBodPill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Controllers
{
    public class HomeController : Controller
    {
        public SignInManager<User> _signInManager;

        public HomeController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User) && User.IsInRole(UserRoles.Admin))
            {
                return Redirect("/AdminDash");
            }
            return View();
        }
    }
}
