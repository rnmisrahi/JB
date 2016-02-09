using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DateSpanClient.ImpreciseServiceReference1;
using DateSpanClient.PreciseServiceReference;

namespace DateSpanClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(Models.ImpreciseDateCalc dateCalc)
        {
            //Models.ImpreciseDateCalc dateCalc = new Models.ImpreciseDateCalc();
            //if (dateCalc == null)
            //{
            //    return View(new Models.ImpreciseDateCalc());
            //}

            //dateCalc.DOB = "2009-03-08";
            //dateCalc.DateFrom = "";
            return View(dateCalc);
        }

        [HttpPost]
        public ActionResult Calculate(Models.ImpreciseDateCalc calc)
        {
            DateTime date = DateTime.Parse(calc.DOB);
            DateTime fromDate = DateTime.Parse(calc.DateFrom);
            DateTime toDate = DateTime.Parse(calc.DateTo);

            using (ImpreciseServiceClient client = new ImpreciseServiceClient())
            {
                calc.Age = client.GetAge(date);
                calc.Years = client.AgeDifference(fromDate, toDate);
            }

            //PreciseServiceClient preciseClient = new PreciseServiceClient();
            //calc.Age = preciseClient.GetAge(date);
            //calc.PreciseYears = preciseClient.AgeDifference(fromDate, toDate);

            return RedirectToAction("Index", calc);
        }
    }
}
