using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validacion.Models;

namespace Validacion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(MemberRepository.Members);
        }

        public ActionResult Edit(int Id)
        {
            Member member = MemberRepository.Members.FirstOrDefault(m => m.MemberId == Id);
            if (ModelState.IsValid)
            {
                Response.Write("Yes, it's Valid");
            }
            else
            {
                Response.Write("Nope. There is an error");
            }
            return View(member);
        }

        [HttpPost]
        public ActionResult Edit(Member member)
        {
            Member m1 = MemberRepository.Members.FirstOrDefault(m => m.MemberId == member.MemberId);
            MemberRepository.replaceMember(m1, member);
            return RedirectToAction("Index");
        }

        public ActionResult CheckNickname(Member member)
        {
            if (member.NickName.Contains("a"))
            {
                return Json(string.Format("{0} is reserved, enter another nickname", member.NickName), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }
    }
}