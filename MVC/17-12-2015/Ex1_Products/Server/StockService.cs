using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    
    public class StockService : IStockService
    {
       
        public List<Product> GetAllProducts()
        {
            return Repository.GetAllProducts();
        }

        public void AddProduct(string productName, int amount)
        {
            Repository.AddProduct(productName, amount); ;
        }

        public void AddAmount(int productID, int amount)
        {
            Repository.AddAmount(productID, amount);
        }

        public void SubAmount(int productID, int amount)
        {
            Repository.SubAmount(productID, amount);
        }
    }
}
