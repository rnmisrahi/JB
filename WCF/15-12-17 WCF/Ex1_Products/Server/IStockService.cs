using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract]
        List<Product> GetAllProducts();
        [OperationContract]
        void AddProduct(string productName, int amount);
        [OperationContract]
        void AddAmount(int productID, int amount);
        [OperationContract]
        void SubAmount(int productID, int amount);
    }
}
