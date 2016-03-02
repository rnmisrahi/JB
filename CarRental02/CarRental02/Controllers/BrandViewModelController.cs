using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRental02.Models;
using CarRental02.ViewModels;

namespace CarRental02.Controllers
{
    public class BrandViewModelController : Controller
    {

        // GET: BrandViewModel
        public ActionResult Index()
        {
            BrandViewModel model = ViewModelFactory.CreateBrandViewModel(null, "");
            return View("Index", model);
        }

        [HttpPost]
        public ActionResult New()
        {
            BrandViewModel bvm = ViewModelFactory.CreateBrandViewModel(null, "WriteOnly");
            return View("Index", bvm);
        }

        [HttpPost]
        public ActionResult Insert(CarBrand brand)
        {
            BrandViewModel bmv;
            if (ModelState.IsValid)
            {
                using (CarRentalContext db = new CarRentalContext())
                {
                    db.CarBrands.Add(brand);
                    db.SaveChanges();
                    bmv = ViewModelFactory.CreateBrandViewModel(brand, "ReadOnly");
                }
            }
            else
            {
                bmv = ViewModelFactory.CreateBrandViewModel(null, "WriteOnly");
            }
            return View("Index", bmv);
        }

        [HttpPost]
        public ActionResult Select(int id)
        {
            BrandViewModel bvm = ViewModelFactory.CreateBrandViewModel(id, "ReadOnly");
            return View("Index", bvm);
        }

        [HttpPost]
        public ActionResult Edit(int id)
        {
            BrandViewModel bvm = ViewModelFactory.CreateBrandViewModel(id, "ReadWrite");
            return View("Index", bvm);
        }

        [HttpPost]
        public ActionResult Update(CarBrand brand)
        {
            BrandViewModel bmv;
            string displayMode = "";
            if (ModelState.IsValid)
            {
                using(CarRentalContext db = new CarRentalContext())
                {
                    CarBrand existing = db.CarBrands.Find(brand.CarBrandId);
                    existing.BrandName = brand.BrandName;
                    db.SaveChanges();
                }
            }
            else
            {
                displayMode = "ReadWrite";
            }
            bmv = ViewModelFactory.CreateBrandViewModel(brand, displayMode);
            return View("index", bmv);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (CarRentalContext db = new CarRentalContext())
            {
                CarBrand existing = db.CarBrands.Find(id);
                db.CarBrands.Remove(existing);
                db.SaveChanges();

                BrandViewModel bmv = ViewModelFactory.CreateBrandViewModel(null, "");
                return View("Index", bmv);
            }
        }

        [HttpPost]
        public ActionResult Cancel(int id)
        {
            BrandViewModel bvm = ViewModelFactory.CreateBrandViewModel(id, "ReadOnly");
            return View("Index", bvm);
        }

    }
}