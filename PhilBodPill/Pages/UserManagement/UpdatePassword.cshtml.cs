using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhilBodPill.Models;
using PhilBodPill.Models.ViewModels;

namespace PhilBodPill.Pages.UserManagement
{
    public class UpdatePasswordModel : PageModel
    {
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;

        [BindProperty]
        public UpdatePasswordViewModel UpdatePasswordViewModel { get; set; }

        public UpdatePasswordModel(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }
            UpdatePasswordViewModel = new UpdatePasswordViewModel();
            return Page();

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            var user = await _userManager.GetUserAsync(User);
            var changePassword = await _userManager.ChangePasswordAsync(user, UpdatePasswordViewModel.CurrentPassword, UpdatePasswordViewModel.UpdatedPassword);
            return RedirectToPage();
        }
    }
}