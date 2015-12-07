using Registration_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration_DB.Controllers
{
    public class HomeController : Controller
    {
        

        public string Index()
        {
            var context = new MemberContext();

            //context.Members.RemoveRange(context.Members);
            //context.SaveChanges();

            context.Members.Add(new Member { MemberID = 116, MemberName = "Moshe", Seniority = 25, });
            context.Members.Add(new Member { MemberID = 227, MemberName = "Yaakov", Seniority = 12, });
            context.Members.Add(new Member { MemberID = 338, MemberName = "Itzik", Seniority = 6, });
            context.SaveChanges();
            context.Dispose();
            return "Done";
        }

    }
}
