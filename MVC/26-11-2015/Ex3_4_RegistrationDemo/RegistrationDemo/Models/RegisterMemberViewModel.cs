using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class RegisterMemberViewModel
    {
        public Member MemberData { get; set; }
        public List<City> Cities { get; set; }
        [Compare("Password", ErrorMessage = "Passwords have to be identical")]
        public string PasswordClone { get; set; }

        public string Password
        {
            get
            {
                if (MemberData != null)
                    return MemberData.Password;
                else
                    return string.Empty;
            }
            set
            {
                if (MemberData != null)
                    MemberData.Password=value;
            }
        }
    }
}