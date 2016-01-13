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
            StockServiceClient service = new StockServiceClient();
            // Product[] products = service.GetAllProducts();
            List<Product> products = service.GetAllProducts();
            return View(products);
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
    }
}
