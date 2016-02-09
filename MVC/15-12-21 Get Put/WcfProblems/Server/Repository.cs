using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    static class Repository
    {
        public static List<Person> Members { get; set; }

        static Repository()
        {
            Members = new List<Person>
            {
                new Person { PersonID=111, PersonName="Moshe", Amount=1000, },
                new Teacher { PersonID=222, PersonName="Dov", Amount=8000, Seniority=70, },
                new Secretary {PersonID=333, PersonName="Tikva", Amount=5550 , TypingSpeed=80},
            };
        }
    }
}
