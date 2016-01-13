using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_EI_Polymorphism_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStamService" in both code and config file together.
    [ServiceContract]
    public interface IStamService
    {
        [OperationContract]
        string GetMessage();
    }
}
