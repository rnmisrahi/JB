using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DateSpanServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PreciseService" in both code and config file together.
    public class PreciseService : IPreciseService
    {
        public int AgeDifference(DateTime DateA, DateTime DateB)
        {
            throw new NotImplementedException();
        }

        public int GetAge(DateTime Date)
        {
            throw new NotImplementedException();
        }
    }
}
