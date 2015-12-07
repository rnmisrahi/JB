using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class MemberViewModel
    {
        public MemberViewModel()
        {
            MemberData = new Member();
        }
        public Member MemberData { get; set; }
        public string CityName { get; set; }
        [Compare("MemberData.Password",ErrorMessage="Passwords have to be identical")]
        public string PasswordClone { get; set; }
    }
}