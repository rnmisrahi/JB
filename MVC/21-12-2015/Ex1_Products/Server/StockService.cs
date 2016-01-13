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

        public void DeleteProduct(int code, int productID)
        {
            Repository.DeleteProduct(code, productID);
        }

        public void RenameProduct(int code, int productID, string newName)
        {
            Repository.RenameProduct(code, productID, newName);
        }

        public void ZeroAllProducts(int code)
        {
            Repository.ZeroAllProducts(code);
        }
    }
}
