using RegistrationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/


        public ActionResult Index()
        {
            return View(Repository.Members);
        }

        // [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Member m)
        {
            Repository.Add(m);
            return RedirectToAction("Register");
        }

        [ActionName("RegisterMe")]
        public ActionResult Register(int k)
        {
            return null;
        }

        public ActionResult Display(int id)
        {
            Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
                return View(member);
            else
                return View("ErrorPage", (object)string.Format("{0} not found", id));
                // return new ContentResult {  Content = string.Format("{0} not found", id) };
        }

        //public ActionResult Edit(int id)
        //{
        //    Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
        //    if (member != null)
        //    {
        //        return View(member);
        //    }
        //    else
        //        return View("ErrorPage", string.Format("{0} not found", id));
        //}

        //[HttpPost]
        //public ActionResult Edit(Member member)
        //{
        //    Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == member.Id);
        //    if (member != null)
        //    {
        //        currentMember.Name = member.Name;
        //        currentMember.Seniority = member.Seniority;
        //        currentMember.IsProgrammer = member.IsProgrammer;
        //        return RedirectToAction("Index");
        //    }
        //    else
        //        return View("ErrorPage", string.Format("{0} not found", member.Id));
        //}

        public ActionResult Edit()
        {
            if (Request.HttpMethod == "GET")
            {
                #region GET Code
                #region Get id
                int id;
                if (Request["id"] != null)
                {
                    id = int.Parse(Request["id"]);
                }
                else
                {
                    string[] UrlParts = Request.RawUrl.Split('/');
                    id = int.Parse(UrlParts[UrlParts.Length - 1]);
                }
                #endregion
                #region Get member
                Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
                if (member != null)
                {
                    return View(member);
                }
                else
                    return View("ErrorPage", string.Format("{0} not found", id));
                
                #endregion
                #endregion
            }
            else
            {
                #region POST Code
                #region Binding
                Member member = new Member
                {
                    Id=int.Parse(Request["id"]),
                    Name=Request["Name"],
                    Seniority = int.Parse(Request["Seniority"]),
                    IsProgrammer=bool.Parse(Request["IsProgrammer"].Split(',')[0]),
                };
                #endregion
                #region Update
                Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == member.Id);
                if (currentMember != null)
                {
                    currentMember.Name = member.Name;
                    currentMember.Seniority = member.Seniority;
                    currentMember.IsProgrammer = member.IsProgrammer;
                    return RedirectToAction("Index");
                }
                else
                    return View("ErrorPage", string.Format("{0} not found", member.Id));
                #endregion
                #endregion
            }
        }

        public ActionResult Delete(int id)
        {
            Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (currentMember != null)
                return View(currentMember);
            else
                return View("ErrorPage", string.Format("{0} not found", id));
                // return new ContentResult { Content = string.Format("{0} not found", id) };
        }

        [HttpPost]
        public ActionResult Delete(Member member) 
        {
            Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == member.Id);
            if (currentMember != null)
            {
                Repository.Members.Remove(currentMember);
                return RedirectToAction("Index");
            }
            else
                return View("ErrorPage", string.Format("{0} not found", member.Id));
                // return new ContentResult { Content = string.Format("{0} not found", member.Id) };

        }
    }
}
