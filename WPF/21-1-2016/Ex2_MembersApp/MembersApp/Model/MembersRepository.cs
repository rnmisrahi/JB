using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersApp.Model
{
    public static class MembersRepository
    {
        private static List<Member> Members;

        static MembersRepository()
        {
            Members = new List<Member>()
            {
                new Member {ID=111, Name="Moshe", CityID=3000, Amount=1500, IsActive=true,},
                new Member {ID=222, Name="Shlomo", CityID=4000, Amount=2200, IsActive=false,},
                new Member {ID=333, Name="Baruch", CityID=3000, Amount=-1200, IsActive=true,},
            };
        }

        public static List<Member> GetAll()
        {
            return Members;
        }

        public static bool Delete(int index)
        {
            if (index >= 0 && index < Members.Count)
            {
                Members.RemoveAt(index);
                return true;
            }
            return false;
        }

        public static bool Add(Member member)
        {
            Members.Add(member);
            return true;
        }
    }
}
