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
            if (currentMember != null)
            {
                //if (member.Id < 100 || member.Id > 9999)
                //    ModelState.AddModelError("Id", "Id value must be 100-9999");
                if (member.Name.Length < 3)
                    ModelState.AddModelError("Name", "Minimum name length is 3 characters");
                if (member.Name.Length > 12)
                    ModelState.AddModelError("Name", "Maximum name length is 12 characters");
                if (member.Seniority < 0 || member.Seniority > 50)
                    ModelState.AddModelError("Seniority", "Seniority 0-50");
                if (Underage(member.BirthDate, 18))
                    ModelState.AddModelError("BirthDate", "You are under 18 kid. Sorry, no can do.");
                if (Overage(member.BirthDate, 100))
                    ModelState.AddModelError("BirthDate", "You are an old fart. Sorry, no can do.");

                if (ModelState.IsValid)
                {
                    currentMember.Name = member.Name;
                    currentMember.Seniority = member.Seniority;
                    currentMember.IsProgrammer = member.IsProgrammer;
                    currentMember.CityId = member.CityId;
                    currentMember.BirthDate = member.BirthDate;
                    currentMember.IsAcceptConditions = member.IsAcceptConditions;
                    return RedirectToAction("Index");
                }
                else
                {
                    EditMemberViewModel emvm = new EditMemberViewModel
                    {
                        MemberData=member,
                        Cities=CityRepository.Cities,
                    };
                    return View(emvm);
                }
            }
            else
                return View("ErrorPage", string.Format("{0} not found", member.Id));
        }

        private bool Underage(DateTime dateTime, int age)
        {
            DateTime dt = dateTime.AddYears(age);
            int res = DateTime.Compare(dt, DateTime.Now);
            return res > 0;

        }

        private bool Overage(DateTime dateTime, int age)
        {
            DateTime dt = dateTime.AddYears(age);
            int res = DateTime.Compare(dt, DateTime.Now);
            return res < 0;
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
