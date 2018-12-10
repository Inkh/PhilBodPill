using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models.ViewModels
{
    public class UpdatePasswordViewModel
    {

        /// <summary>
        /// Current Password of User
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Your Current Password")]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// New password
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string UpdatedPassword { get; set; }

        /// <summary>
        /// Confirm new password. Has to match previous field
        /// </summary>
        [Required]
        [Compare("UpdatedPassword", ErrorMessage = "New password does not match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        public string ConfirmUpdatedPassword { get; set; }
    }
}
