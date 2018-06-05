using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Models
{
    public class UserDTO : IdentityUser
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
    }
}
