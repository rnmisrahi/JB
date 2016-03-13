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
            CarModelViewModel cmvm = ViewModelFactory.CreateCarModelViewModel();
            return View(cmvm);
        }

        // POST: CarModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarModelViewModel cmvm)
        {
            if (ModelState.IsValid)
            {
                db.CarModels.Add(cmvm.CarModelData);
                db.SaveChanges();
                TempData["Added"] = cmvm.CarModelData.Description + " Added";
                return RedirectToAction("Index");
            }
            cmvm = ViewModelFactory.CreateCarModelViewModel(cmvm.CarModelData);
            return View(cmvm);
        }

        // GET: CarModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModelViewModel cmvm = ViewModelFactory.CreateCarModelViewModel(id);
            if (cmvm == null)
            {
                return HttpNotFound();
            }
            return View(cmvm);
        }

        // POST: CarModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CarModelViewModel cmvm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cmvm.CarModelData).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Added"] = cmvm.CarModelData.Description + " Edited";
                return RedirectToAction("Index");
            }
            cmvm = ViewModelFactory.CreateCarModelViewModel(cmvm.CarModelData);
            return View(cmvm);
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
            //TempData["Added"] = cmvm.CarModelData.Description + " Added";
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
