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
            // StartDB();
        }

        public static void StartDB()
        {
            using (var context = new StockDbContext())
            {
                context.Products.Add(new Product { ProductID = 1010, ProductName = "Bag", Amount = 30, });
                context.Products.Add(new Product { ProductID = 2020, ProductName = "Screen", Amount = 12, });
                context.Products.Add(new Product { ProductID = 3030, ProductName = "Chair", Amount = 25, });

                context.SaveChanges();
            };
        }

        public static void AddProduct(string productName,int amount) 
        {
            using (var context = new StockDbContext())
            {
                Product p = new Product
                {
                    ProductID = GetNewID(),
                    ProductName = productName,
                    Amount = amount,
                };
                context.Products.Add(p);
                context.SaveChanges();
            }
        }

        private static int GetNewID()
        {
            using (var context = new StockDbContext())
            {
                Random r = new Random();
                int newId = r.Next(1001, 9999);
                while (context.Products.FirstOrDefault(p => p.ProductID == newId) != null)
                {
                    newId = r.Next(1001, 9999);
                }

                return newId;
            }
        }

        public static void AddAmount(int productID, int amount)
        {
            using (var context = new StockDbContext())
            {
                Product product = context.Products.FirstOrDefault(p => p.ProductID == productID);
                if (product != null)
                {
                    product.Amount += amount;
                }
                context.SaveChanges();
            }
        }

        public static void SubAmount(int productID, int amount)
        {
            using (var context = new StockDbContext())
            {
                Product product = context.Products.FirstOrDefault(p => p.ProductID == productID);
                if (product != null)
                {
                    product.Amount -= amount;
                }
                context.SaveChanges();
            }
        }

        public static List<Product> GetAllProducts()
        {
            using (var context = new StockDbContext())
            {
                return context.Products.ToList();
            }
        }


        public static void DeleteProduct(int code, int productID)
        {
            if (code == Security.MANAGER_CODE)
            {
                using (var context = new StockDbContext())
                {
                    var product = context.Products.FirstOrDefault(p => p.ProductID == productID);
                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                    }
                }
            }
        }
        public static void RenameProduct(int code, int productID, string newName)
        {
            if (code == Security.MANAGER_CODE)
            {
                using (var context = new StockDbContext())
                {
                    var product = context.Products.FirstOrDefault(p => p.ProductID == productID);
                    if (product != null)
                    {
                        product.ProductName = newName;
                        context.SaveChanges();
                    }
                }
            }
        }
        public static void ZeroAllProducts(int code)
        {
            if (code == Security.MANAGER_CODE)
            {
                using (var context = new StockDbContext())
                {
                    context.Products.ToList().ForEach(p => p.Amount = 0);
                    context.SaveChanges();
                }
            }
        }
    }
}
