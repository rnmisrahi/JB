using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServer.Model;
using System.ServiceModel;

namespace WCFServer
{
    [ServiceContract]
    interface IInventory
    {
        [OperationContract]
        string GetMessage();

        [OperationContract]
        int AddItem(String name, int quantity);

        [OperationContract]
        int AddQuantity(int itemId, int quantity);

        [OperationContract]
        int SubtractQuantity(int itemId, int quantity);

        [OperationContract]
        List<Item> GetItems();
    }
}
