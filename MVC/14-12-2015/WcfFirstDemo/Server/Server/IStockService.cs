using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [ServiceContract]
    interface IStockService
    {
        [OperationContract]
        double GetPrice(string productName, int prefix);

        [OperationContract]
        string GetMessage();

        [OperationContract(Name="GetMessageX")]
        string GetMessage(int x);
    }
}
