using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ef6.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }

        public City City { get; set; }
    }

}