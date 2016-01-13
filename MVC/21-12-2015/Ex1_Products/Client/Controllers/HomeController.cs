using Client.StockService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            try
            {
                StockServiceClient service = new StockServiceClient();
                Product[] products = service.GetAllProducts();
                return View(products);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //
        // GET: /Home/Details/5

        public ActionResult AddNewProduct()
        {
            return View(new Product());
        }

        
        [HttpPost]
        public ActionResult AddNewProduct(string productName, int amount)
        {
            StockServiceClient service = new StockServiceClient();
            service.AddProduct(productName, amount);
            return RedirectToAction("Index");
        }

        public ActionResult AddAmount(int productID, string productName)
        {
            return View(new Product { ProductID = productID, ProductName = productName });
        }

        [HttpPost]
        public ActionResult AddAmount(Product product)
        {
            StockServiceClient service = new StockServiceClient();
            service.AddAmount(product.ProductID, product.Amount);
            return RedirectToAction("Index");
        }

        public ActionResult SubAmount(int productID, string productName)
        {
            return View(new Product { ProductID = productID, ProductName = productName });
        }

        [HttpPost]
        public ActionResult SubAmount(Product product)
        {
            StockServiceClient service = new StockServiceClient();
            service.SubAmount(product.ProductID, product.Amount);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(int productID, string productName)
        {
            Product product = new Product { ProductID = productID, ProductName = productName };
            return View(product);
        }

        [HttpPost]
        public ActionResult DeleteProduct(int productID, int code = 0)
        {
            StockServiceClient service = new StockServiceClient();
            service.DeleteProduct(code, productID);
            return RedirectToAction("Index");
        }

        public ActionResult RenameProduct(int productID, string productName)
        {
            Product product = new Product { ProductID = productID, ProductName = productName };
            return View(product);
        }

        [HttpPost]
        public ActionResult RenameProduct(int productID, string newName, int code = 0)
        {
            StockServiceClient service = new StockServiceClient();
            service.RenameProduct(code, productID,newName);
            return RedirectToAction("Index");
        }

        public ActionResult ZeroAllProducts()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ZeroAllProducts(int code = 0)
        {
            StockServiceClient service = new StockServiceClient();
            service.ZeroAllProducts(code);
            return RedirectToAction("Index");
        }

    }
}
