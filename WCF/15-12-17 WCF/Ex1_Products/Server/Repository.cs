using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public static class Repository
    {
        public static List<Product> Products { get; private set; }

        static Repository() 
        {
            Products = new List<Product>
            {
                new Product { ProductID=1010, ProductName="Bag", Amount=30, },
                new Product { ProductID=2020, ProductName="Screen", Amount=12, },
                new Product { ProductID=3030, ProductName="Chair", Amount=25, },
            };
        }

        public static void AddProduct(string productName,int amount) 
        {
            Product p = new Product
            {
                ProductID=GetNewID(),
                ProductName=productName,
                Amount=amount,
            };
            Products.Add(p);
        }

        private static int GetNewID()
        {
            Random r = new Random();
            int newId = r.Next(1001, 9999);
            while (Products.FirstOrDefault(p => p.ProductID == newId) != null)
            {
                newId = r.Next(1001, 9999);
            }

            return newId;
        }

        public static void AddAmount(int productID, int amount)
        {
            Product product = Products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                product.Amount += amount;
            }
        }

        public static void SubAmount(int productID, int amount)
        {
            Product product = Products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                product.Amount -= amount;
            }
        }

        public static List<Product> GetAllProducts()
        {
            return Products;
        }
    }
}
