using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhilBodPill.Models;
using PhilBodPill.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PhilBodPill.Controllers
{
    public class UserController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Fail()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if(ModelState.IsValid)
            {
                User user = new User()
                {
                    UserName = rvm.UserName,
                    FirstName = rvm.FirstName,
                    LastName = rvm.LastName,
                    UserEmail = rvm.UserEmail,
                    UserState = rvm.UserState,
                    UserStreet = rvm.UserStreet,
                    UserZip = rvm.UserZip,
                    City = rvm.City
                };

                var result = await _userManager.CreateAsync(user, rvm.Password);

                if (result.Succeeded)
                {
                    Claim greeting = new Claim("greeting", $"Welcome back, {user.FirstName}");
                    Claim firstNameLower = new Claim("firstNameLower", user.FirstName.ToLower());
                    List<Claim> myClaims = new List<Claim>()
                    {
                        greeting,
                        firstNameLower
                    };
                    await _userManager.AddClaimsAsync(user, myClaims);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction(nameof(Fail));
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.UserName, lvm.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToLocal(returnUrl);
                }
            }
            else
            {
                ModelState.AddModelError("", "You did a bad!");
            }
            return RedirectToAction(nameof(Fail));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
