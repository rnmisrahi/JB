using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            using (var context = new MemberContext())
            {
                //context.MemberList.RemoveRange(context.MemberList);
                //context.SaveChanges();

                context.MemberList.Add(new Member { Name="Ruben Misrahi", Seniority=11});
                context.MemberList.Add(new Member { Name = "Lulu", Seniority = 2 });
                context.MemberList.Add(new Member { Name = "Yael", Seniority = 3 });
                context.MemberList.Add(new Member { Name = "Orit", Seniority = 4 });
                context.MemberList.Add(new Member { Name = "Meytal", Seniority = 5 });
                context.SaveChanges();

                return "Done";
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}