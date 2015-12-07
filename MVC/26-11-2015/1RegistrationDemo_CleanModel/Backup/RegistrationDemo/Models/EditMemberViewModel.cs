using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class EditMemberViewModel
    {
        public Member MemberData { get; set; }
        public List<City> Cities { get; set; }
    }
}