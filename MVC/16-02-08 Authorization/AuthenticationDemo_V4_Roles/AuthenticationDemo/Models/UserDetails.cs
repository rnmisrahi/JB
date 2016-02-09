using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationDemo.Models
{
    public class UserDetails
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmailAddress { get; set; }
        public List<string> UserRoles { get; set; }

        public UserDetails()
        {
            UserRoles = new List<string>();
        }
    }
}