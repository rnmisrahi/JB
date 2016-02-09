using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ef6Demo.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public int Amount { get; set; }
        public bool IsProgrammer { get; set; }

        public City City { get; set; }
    }
}