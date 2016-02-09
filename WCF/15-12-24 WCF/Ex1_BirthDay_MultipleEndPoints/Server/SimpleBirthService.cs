using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class SimpleBirthService : IBirthService
    {
        public int GetAge(DateTime birthDate)
        {
            return GetDifference(DateTime.Today,  birthDate);
        }

        public int GetDifference(DateTime first, DateTime second)
        {
            return first.Year - second.Year;
        }
    }
}
