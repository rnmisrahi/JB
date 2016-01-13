using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSpanServer
{
    public class DateDiffPrecise
    {
        public int Age(DateTime date)
        {
            return YearDiff(date, DateTime.Today);
        }

        public int YearDiff(DateTime dateA, DateTime dateB)
        {
            int yearA = dateA.Year;
            int yearB = dateB.Year;
            int years = yearB - yearA;
            DateTime d = dateB.AddYears(-years); //To set the year the same
            if (d.Date < dateA.Date)
                years--;
            return years;
        }
    }
}
