using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class SqlController : Controller
    {
        // GET: Sql
        public ActionResult Index()
        {
            using (var context = new BloggingContext())
            {
                var blogs = context.Blogs.SqlQuery("SELECT * FROM dbo.Blogs").ToList();
            }
            return View();
        }
    }
}