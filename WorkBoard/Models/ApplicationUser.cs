using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkBoard.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
    }
}
