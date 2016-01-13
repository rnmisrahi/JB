using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Validacion.Models
{
    public static class MemberRepository
    {
        public static List<Member> Members = new List<Member>
        {
            new Member{MemberId=1, MemberName="John", NickName="Johny", Phone="262376", Salary=37483 },
            new Member {MemberId=2,MemberName="Michael", NickName="Mike" ,Phone ="39847938", Salary=39845},
            new Member {MemberId=3,MemberName="Stephen",NickName="Steve", Salary=287374 }
        };

        public static void replaceMember(Member target, Member source)
        {
            target.MemberId     = source.MemberId;
            target.MemberName   = source.MemberName;
            target.NickName     = source.NickName  ;
            target.Phone        = source.Phone     ;
            target.Salary       = source.Salary    ;
        }
    }
}