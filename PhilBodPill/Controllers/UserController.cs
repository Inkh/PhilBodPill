using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using PhilBodPill.Data;
using PhilBodPill.Models;
using PhilBodPill.Models.ViewModels;
using SendGrid.Helpers.Mail;
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
        private UserDbContext _context;
        private IEmailSender _email;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, UserDbContext context, IEmailSender email)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _email = email;
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
                CheckUserRolesExist();

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
                    await _email.SendEmailAsync("jhwe92@gmail.com", "Thanks for registering", "<p>Hello!</p>");
                    Claim greeting;
                    if (user.FirstName.ToLower() == "chet")
                    {
                        greeting = new Claim("greeting", "Dammit Chet!");
                    }
                    else
                    {
                        greeting = new Claim("greeting", $"Hello, {user.FirstName}!");
                    }
                    Claim firstNameLower = new Claim("firstNameLower", user.FirstName.ToLower());
                    Claim userID = new Claim("userID", user.Id);
                    List<Claim> myClaims = new List<Claim>()
                    {
                        greeting,
                        firstNameLower,
                        userID
                    };

                    List<string> adminList = new List<string> { "nethwebdev@gmail.com", "admin@admin.com", "amanda@codefellows.com" };

                    if (adminList.Contains(rvm.UserEmail))
                    {
                        await _userManager.AddToRoleAsync(user, UserRoles.Admin);
                    }
                    await _userManager.AddToRoleAsync(user, UserRoles.User);
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

        public void CheckUserRolesExist()
        {
            if (!_context.Roles.Any())
            {
                List<IdentityRole> Roles = new List<IdentityRole>
                {
                    new IdentityRole{Name = UserRoles.Admin, NormalizedName=UserRoles.Admin.ToString(), ConcurrencyStamp = Guid.NewGuid().ToString()},
                    new IdentityRole{Name = UserRoles.User, NormalizedName=UserRoles.User.ToString(), ConcurrencyStamp = Guid.NewGuid().ToString()},
                };

                foreach (var role in Roles)
                {
                    _context.Roles.Add(role);
                    _context.SaveChanges();
                }
            }
        }
    }
}
