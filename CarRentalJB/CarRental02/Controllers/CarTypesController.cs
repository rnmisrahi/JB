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
    public class CarTypesController : Controller
    {
        private CarRentalContext db = new CarRentalContext();

        // GET: CarTypes
        public ActionResult Index()
        {
            var carTypes = db.CarTypes.Include(c => c.CarModel);
            var carTypesX = db.CarTypes.Include(c => c.CarModel).OrderBy(c=>c.CarModelId);
            return View(carTypesX.ToList());
        }

        // GET: CarTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarType carType = db.CarTypes.Find(id);
            if (carType == null)
            {
                return HttpNotFound();
            }
            return View(carType);
        }

        // GET: CarTypes/Create
        public ActionResult Create()
        {
            CarTypeViewModel ctvm = ViewModelFactory.CreateCarTypeViewModel();
            return View(ctvm);
        }

        // POST: CarTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarTypeViewModel ctvm)
        {
            if (ModelState.IsValid)
            {
                db.CarTypes.Add(ctvm.CarTypeData);
                db.SaveChanges();
                TempData["Added"] = ctvm.CarTypeData.Description + " Added";
                return RedirectToAction("Index");
            }
            ctvm = ViewModelFactory.CreateCarTypeViewModel();
            return View(ctvm);
        }

        // GET: CarTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarTypeViewModel ectvm = ViewModelFactory.CreateCarTypeViewModel(id);
            if (ectvm == null)
            {
                return HttpNotFound();
            }
            return View(ectvm);
        }

        // POST: CarTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "CarTypeId,CarCode,CarModelId,DailyPrice,DailyLatePrice,Gear")] CarType carType)
        public ActionResult Edit(CarTypeViewModel ctvm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ctvm.CarTypeData).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Added"] = ctvm.CarTypeData.Description + " Edited";
                return RedirectToAction("Index");
            }
            ctvm = ViewModelFactory.CreateCarTypeViewModel(ctvm.CarTypeData);
            return View(ctvm);
        }

        // GET: CarTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarType carType = db.CarTypes.Find(id);
            if (carType == null)
            {
                return HttpNotFound();
            }
            return View(carType);
        }

        // POST: CarTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarType carType = db.CarTypes.Find(id);
            db.CarTypes.Remove(carType);
            db.SaveChanges();
            //TempData["Added"] = ctvm.CarTypeData.Description + " Edited";
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
