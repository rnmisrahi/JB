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
    public class CarsController : Controller
    {
        private CarRentalContext db = new CarRentalContext();

        // GET: Cars
        public ActionResult Index()
        {
            var cars = db.Cars.Include(c => c.Branch).Include(c => c.CarType);
            return View(cars.ToList());
        }

        // GET: Cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            CarViewModel ecvm = ViewModelFactory.CreateCarViewModel();
            return View(ecvm);
        }

        // POST: Cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "CarId,CarTypeId,BranchId,CarColor,Kilometrage,Picture,Plates,CarStatus,Comments")] Car car)
        public ActionResult Create(CarViewModel cvm)
        {
            TempData["Car"] = cvm.CarData;
            if (ModelState.IsValid)
            {
                db.Cars.Add(cvm.CarData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //Validation failed:

            cvm = ViewModelFactory.CreateCarViewModel(cvm.CarData);
            return View(cvm);
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarViewModel ecvm = ViewModelFactory.CreateCarViewModel(id);
            return View(ecvm);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "CarId,CarTypeId,BranchId,CarColor,Kilometrage,Picture,Plates,CarStatus,Comments")] Car car)
        public ActionResult Edit(CarViewModel cvm)
        {
            if (ModelState.IsValid)
            {
                db.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
                db.Entry(cvm.CarData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            cvm = ViewModelFactory.CreateCarViewModel(cvm.CarData);
            return View(cvm);
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
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
