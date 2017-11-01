using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTtest.Models
{
    public class User : IdentityUser
    {
        public DateTime JoinDate { get; set; }
        public string JobTitle { get; set; }
        public string Contract { get; set; }
        public bool IsEmployed { get; set; }

    }
}
