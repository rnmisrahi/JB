using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStockServiceConfig" in both code and config file together.
    [ServiceContract]
    public interface IStockServiceConfig
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        double GetPrice(string productName, int prefix);

        [OperationContract]
        string GetMessage();

        [OperationContract(Name = "GetMessageX")]
        string GetMessage(int x);

    }
}
