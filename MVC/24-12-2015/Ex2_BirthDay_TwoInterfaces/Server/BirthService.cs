using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BirthService" in both code and config file together.
    public class BirthService : ISimpleBirthService, IExactBirthService
    {
        public int GetAgeSimple(DateTime birthDate)
        {
            return GetDifferenceSimple(DateTime.Today, birthDate);
        }

        public int GetDifferenceSimple(DateTime first, DateTime second)
        {
            return first.Year - second.Year;
        }

        public int GetAgeExact(DateTime birthDate)
        {
            return GetDifferenceExact(DateTime.Today, birthDate);
        }

        public int GetDifferenceExact(DateTime first, DateTime second)
        {
            int difference = first.Year - second.Year;
            if (first.Month < second.Month ||
                    first.Month == second.Month && first.Day < second.Day)
            {
                difference--;
            }
            return difference;
        }
    }
}
