using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookiesDemo.Models
{
    public class RegistrationInfo
    {
        [Display(Name="User Name")]
        public string Usr { get; set; }
        public string Profession { get; set; }
        public int  UserID { get; set; }
        public bool IsRegistered { get; set; }
        public bool HasCookies { get; set; }
    }
}