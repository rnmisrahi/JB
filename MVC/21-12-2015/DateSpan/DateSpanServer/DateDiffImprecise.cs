using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSpanServer
{
    public class DateDiffImprecise
    {
        public int Age(DateTime date)
        {
            int currentYear = DateTime.Today.Year;
            int dateYear = date.Year;
            return currentYear - dateYear;
        }

        public int YearDiff(DateTime a, DateTime b)
        {
            return b.Year - a.Year;
        }
    }
}
