using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public static class Repository
    {
        public static List<Member> Members = new List<Member>
        {
            new Member { Id=111, Name="Moshe", Seniority=21,},
            new Member { Id=222, Name="Shalva", Seniority=4,},
            new Member { Id=333, Name="Tikva", Seniority=17,},
        };

        public static void Add(Member m)
        {
            Members.Add(m);
        }

        public static void Edit(Member m, Member newMember)
        {
            m.Id = newMember.Id;
            m.Name = newMember.Name;
            m.Seniority = newMember.Seniority;
        }
    }
}