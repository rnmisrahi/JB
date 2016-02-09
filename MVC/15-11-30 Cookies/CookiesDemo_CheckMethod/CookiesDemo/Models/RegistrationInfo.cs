using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookiesDemo.Models
{
    public class RegistrationInfo
    {
        public string Username { get; set; }
        public string Profession { get; set; }
        public int  UserID { get; set; }
        public bool IsRegistered { get; set; }
        public bool HasCookies { get; set; }
    }
}