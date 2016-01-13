using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService4.Model
{
    public static class MemberController
    {
        public static List<Member> Members = new List<Member>
        {
            new Member {MemberName="Ruben" },
            new Member {MemberName="Lulu" },
            new Member {MemberName="Yael" },
            new Member {MemberName="Orit" },
            new Member {MemberName="Meytal" },
        };
    }
}