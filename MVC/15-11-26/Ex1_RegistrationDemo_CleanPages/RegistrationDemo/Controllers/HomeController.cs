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
        public ActionResult Index()
        {
            return View(ViewModelFactory.CreateIndexViewModel());
        }

        public ActionResult Register()
        {
            EditMemberViewModel rvm = new EditMemberViewModel
            {
                MemberData=new Member(),
                Cities = CityRepository.Cities
            };
            
            return View(rvm);
        }

        [HttpPost]
        public ActionResult Register(Member member)
        {
            if (DateTime.Today.Year - member.BirthDate.Year - member.Seniority < 14)
            {
                ModelState.AddModelError("Seniority", "We count your seniority from age of 14 only");
            }

            if (ModelState.IsValid)
            {
                Repository.Add(member);
                return RedirectToAction("Index");
            }
            else
            {
                return View(new EditMemberViewModel { MemberData = member, Cities = CityRepository.Cities });
            }
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
                if (DateTime.Today.Year - member.BirthDate.Year - member.Seniority < 14)
                {
                    ModelState.AddModelError("Seniority", "We count your seniority from age of 14 only");
                }

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
                    return View(new EditMemberViewModel {MemberData = member, Cities = CityRepository.Cities});
                }
            }
            else
                return View("ErrorPage", string.Format("{0} not found", member.Id));
        }

        public ActionResult Delete(int id)
        {
            Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == id);
            if (currentMember != null)
            {
                Random rnd = new Random();
                int first = rnd.Next(1, 9);
                int second = rnd.Next(1, 9);
                DeleteMemberViewModel delVm = new DeleteMemberViewModel
                {
                    MemberData = currentMember,
                    RightAnswer = first + second,
                    Exercise = first.ToString() + " + " + second.ToString(),
                };
                return View(delVm);
            }
            else
                return View("ErrorPage", string.Format("{0} not found", id));
        }

        [HttpPost]
        public ActionResult Delete(DeleteMemberViewModel member) 
        {
            Member currentMember = Repository.Members.FirstOrDefault(m => m.Id == member.MemberData.Id);
            if (currentMember != null)
            {
                if (member.UserAnswer != member.RightAnswer)
                {
                    ModelState.AddModelError("UserAnswer", "You must enter the correct answer");
                }

                if (ModelState.IsValid)
                {
                    Repository.Members.Remove(currentMember);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(member);
                }
            }
            else
                return View("ErrorPage", string.Format("{0} not found", member.MemberData.Id));
        }
    }
}
