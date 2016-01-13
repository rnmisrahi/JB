using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [ServiceContract]
    interface IStockService
    {
        [OperationContract]
        double GetPrice(string productName);

        [OperationContract]
        string GetMessage();
    }
}
