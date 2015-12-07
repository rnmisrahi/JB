using RegistrationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace RegistrationDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [HttpGet]
        public ActionResult Index()
        {
            return View(Repository.Members);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]        
        public ActionResult Register(Member m)
        {
            Repository.Add(m);
            // return View("RegistrationPage");
            return RedirectToAction("Register");
        }

        [ActionName("RegisterMe")]
        public ActionResult Register(int k)
        {
            return null;
        }

        public ActionResult Display(int? id)
        {
            try
            {
                if (id != null)
                {
                    Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
                    if (member != null)
                        return View(member);
                    else
                        throw new Exception(string.Format("{0} not found", id));
                }
                else
                    throw new Exception("Invalid Request: id is null");
            }
            catch (Exception ex)
            {
                return new ContentResult { Content = string.Format("Error: {0}", ex.Message) };
            }
        }

        [HttpPost]
        public ActionResult Edit(int id)
        {
            Debug.WriteLine("NU?");
            Debug.WriteLine("Request.Params[0] {0}", Request.Params[0]);
            Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
            {
                return View(member);
            }
            else
                return new ContentResult { Content = string.Format("{0} not found", id) };
        }

        [HttpPost]
        [ActionName("EditMember")]
        public ActionResult Edit(Member member)
        {
            try
            {
                if ((member != null) && (member.Id != null))
                {
                    Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == member.Id);
                    if (currentMember != null)
                    {
                        if (member.Id != member.newId) //The Id changed
                        {
                            currentMember.Id = member.newId;
                        }

                        currentMember.Name = member.Name;
                        currentMember.Seniority = member.Seniority;
                        currentMember.IsAProgrammer = member.IsAProgrammer;
                        return RedirectToAction("Index");
                    }
                }
                throw new Exception(String.Format("{0} Not found", member.Id));
            }
            catch (Exception ex)
            {
                return new ContentResult { Content = string.Format("Error: {0}", ex.Message) };
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (currentMember != null)
            {
                Repository.Members.Remove(currentMember);
                return RedirectToAction("Index");
            }
            else
                return new ContentResult { Content = string.Format("{0} not found", id) };

        }
    }
}
