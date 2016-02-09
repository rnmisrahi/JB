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
        // GET: Home
        public ActionResult Index()
        {
            StockServiceClient service = new StockServiceClient();
            return View(service.GetAllProducts());
        }
    }
}