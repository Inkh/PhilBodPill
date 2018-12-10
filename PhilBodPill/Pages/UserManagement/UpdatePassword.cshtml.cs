using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhilBodPill.Models;

namespace PhilBodPill.Pages.UserManagement
{
    public class UpdatePasswordModel : PageModel
    {
        private SignInManager<User> _signInManager;

        public UpdatePasswordModel(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }
        [BindProperty]
        public PhilBodPill.Models.User User { get; set; }

        public void OnGet(string id)
        {
            User = await user.
        }
    }
}