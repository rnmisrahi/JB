using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class DeleteMemberViewModel
    {
        public Member MemberData { get; set; }
        public string Exercise { get; set; }
        public int RightAnswer { get; set; }
        public int UserAnswer { get; set; }
    }
}