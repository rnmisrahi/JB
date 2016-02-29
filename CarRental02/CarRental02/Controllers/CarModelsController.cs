using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarRental02.Models;
using CarRental02.ViewModels;

namespace CarRental02.Controllers   
{
    public class CarModelsController : Controller
    {
        private CarRentalContext db = new CarRentalContext();

        // GET: CarModels
        public ActionResult Index()
        {
            var carModels = db.CarModels.Include(c => c.CarBrand).OrderBy(c => c.CarBrandId);
            return View(carModels.ToList());
        }

        // GET: CarModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModel carModel = db.CarModels.Find(id);
            if (carModel == null)
            {
                return HttpNotFound();
            }
            return View(carModel);
        }

        // GET: CarModels/Create
        public ActionResult Create()
        {
            //ViewBag.CarBrandId = new SelectList(db.CarBrands, "CarBrandId", "BrandName");
            CarModelVM carModelVM = new CarModelVM(new CarModel(), db.CarBrands);
            return View(carModelVM);
        }

        // POST: CarModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarModelVM carModelVM)
        {
            if (ModelState.IsValid)
            {
                db.CarModels.Add(carModelVM.CarModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //This is needed to restore the brands, which did not come back from the View
            carModelVM = new CarModelVM(carModelVM.CarModel, db.CarBrands);
            return View(carModelVM);
        }

        // GET: CarModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModel CarModel = db.CarModels.Find(id);
            if (CarModel == null)
            {
                return HttpNotFound();
            }
            //This is needed to restore the brands, which did not come back from the View
            CarModelVM carModelVM = new CarModelVM(CarModel, db.CarBrands);
            return View(carModelVM);
        }

        // POST: CarModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CarModelVM carModelVM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carModelVM.CarModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            carModelVM.brandList = new SelectList(db.CarBrands, "CarBrandId", "BrandName", carModelVM.CarModel.CarBrandId);
            //ViewBag.CarBrandId = new SelectList(db.CarBrands, "CarBrandId", "BrandName", carModel.CarBrandId);
            return View(carModelVM);
        }

        // GET: CarModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModel carModel = db.CarModels.Find(id);
            if (carModel == null)
            {
                return HttpNotFound();
            }
            return View(carModel);
        }

        // POST: CarModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarModel carModel = db.CarModels.Find(id);
            db.CarModels.Remove(carModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
