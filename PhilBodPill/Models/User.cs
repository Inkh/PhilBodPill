using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models
{
    public class User : IdentityUser
    {
        public string UID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public string UserStreet { get; set; }
        public int UserZip { get; set; }
        public string UserState { get; set; }
        public string City { get; set; }
    }
}
