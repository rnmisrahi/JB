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
            return View(ViewModelFactory.CreateIndexViewModel());
        }

        // [HttpGet]
        public ActionResult Register()
        {
            return View(CityRepository.Cities);
        }

        [HttpPost]
        public ActionResult Register(Member m)
        {
            Repository.Add(m);
            return RedirectToAction("Index");
        }

        public ActionResult Display(int id)
        {
            Member member = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
            {
                MemberViewModel mvm = new MemberViewModel();
                mvm.MemberData = member;
                City city = CityRepository.Cities.FirstOrDefault(c => c.CityId == member.CityId);
                if (city != null)
                {
                    mvm.CityName = city.CityName;
                }
                return View(mvm);
            }
            else
                return View("ErrorPage", (object)string.Format("{0} not found", id));
        }

        public ActionResult Edit(int id)
        {
            EditMemberViewModel memberVM = ViewModelFactory.CreateEditViewModel(id);
            if (memberVM != null)
            {
                return View(memberVM);
            }
            else
                return View("ErrorPage", string.Format("{0} not found", id));
        }

        [HttpPost]
        public ActionResult Edit(Member member)
        {
            Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == member.Id);
            if (member != null)
            {
                currentMember.Name = member.Name;
                currentMember.Seniority = member.Seniority;
                currentMember.IsProgrammer = member.IsProgrammer;
                currentMember.CityId = member.CityId;
                return RedirectToAction("Index");
            }
            else
                return View("ErrorPage", string.Format("{0} not found", member.Id));
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
        }
    }
}
