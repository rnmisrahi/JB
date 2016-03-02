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
            using (CarRentalContext db = new CarRentalContext())
            {
                BrandViewModel model = new BrandViewModel();
                model.Brands = db.CarBrands.ToList();
                model.SelectedBrand = null;
                return View("Index", model);
            }
        }

        [HttpPost]
        public ActionResult New()
        {
            using (CarRentalContext db = new CarRentalContext())
            {
                BrandViewModel model = new BrandViewModel();
                model.Brands = db.CarBrands.ToList();
                model.SelectedBrand = null;
                model.DisplayMode = "WriteOnly";
                return View("Index", model);
            }
        }

        [HttpPost]
        public ActionResult Insert(CarBrand brand)
        {
            using (CarRentalContext db = new CarRentalContext())
            {
                BrandViewModel model = new BrandViewModel();
                if (ModelState.IsValid)
                {
                    db.CarBrands.Add(brand);
                    db.SaveChanges();
                    model.SelectedBrand = db.CarBrands.Find(brand.CarBrandId);
                    model.DisplayMode = "ReadOnly";
                }
                else {
                    model.SelectedBrand = null;
                    model.DisplayMode = "WriteOnly";
                }
                model.Brands = db.CarBrands.ToList();
                return View("Index", model);
            }
        }

        [HttpPost]
        public ActionResult Select(int id)
        {
            using (CarRentalContext db = new CarRentalContext())
            {
                BrandViewModel model = new BrandViewModel();
                model.Brands = db.CarBrands.ToList();
                model.SelectedBrand = db.CarBrands.Find(id);
                model.DisplayMode = "ReadOnly";
                return View("Index", model);
            }
        }

        [HttpPost]
        public ActionResult Edit(int id)
        {
            using (CarRentalContext db = new CarRentalContext())
            {
                BrandViewModel model = new BrandViewModel();
                model.Brands = db.CarBrands.ToList();
                model.SelectedBrand = db.CarBrands.Find(id);
                model.DisplayMode = "ReadWrite";
                return View("Index", model);
            }
        }

        [HttpPost]
        public ActionResult Update(CarBrand brand)
        {
            using (CarRentalContext db = new CarRentalContext())
            {
                BrandViewModel model = new BrandViewModel();
                CarBrand existing = db.CarBrands.Find(brand.CarBrandId);
                if (ModelState.IsValid)
                {
                    existing.BrandName = brand.BrandName;
                    db.SaveChanges();
                }
                else
                {
                    model.DisplayMode = "ReadWrite";
                }

                model.Brands = db.CarBrands.ToList();
                model.SelectedBrand = existing;
                return View("Index", model);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (CarRentalContext db = new CarRentalContext())
            {
                CarBrand existing = db.CarBrands.Find(id);
                db.CarBrands.Remove(existing);
                db.SaveChanges();

                BrandViewModel model = new BrandViewModel();
                model.Brands = db.CarBrands.ToList();
                model.SelectedBrand = null;
                model.DisplayMode = "";
                return View("Index", model);
            }
        }

        [HttpPost]
        public ActionResult Cancel(int id)
        {
            using (CarRentalContext db = new CarRentalContext())
            {
                BrandViewModel model = new BrandViewModel();
                model.Brands = db.CarBrands.ToList();
                model.SelectedBrand = db.CarBrands.Find(id);
                model.DisplayMode = "ReadOnly";
                return View("Index", model);
            }
        }

    }
}