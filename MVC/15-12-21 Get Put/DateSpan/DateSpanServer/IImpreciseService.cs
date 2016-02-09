using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DateSpanServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IImpreciseService" in both code and config file together.
    [ServiceContract]
    public interface IImpreciseService
    {
        [OperationContract]
        int GetAge(DateTime Date);

        [OperationContract]
        int AgeDifference(DateTime DateA, DateTime DateB);
    }
}
