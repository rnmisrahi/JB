using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public static class Repository
    {
        public static List<Member> Members = new List<Member>();

        public static void Add(Member m)
        {
            Members.Add(m);
        }
    }
}