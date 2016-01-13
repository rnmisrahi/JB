using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DateSpanServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ImpreciseService" in both code and config file together.
    public class ImpreciseService : IImpreciseService
    {
        public int AgeDifference(DateTime DateA, DateTime DateB)
        {
            DateDiffImprecise DateDiff = new DateDiffImprecise();
            return DateDiff.YearDiff(DateA, DateB);
        }

        public int GetAge(DateTime Date)
        {
            DateDiffImprecise DateDiff = new DateDiffImprecise();
            return DateDiff.Age(Date);
        }
    }
}
