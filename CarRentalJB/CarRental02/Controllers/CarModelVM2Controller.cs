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
    public class CarModelVM2Controller : Controller
    {
        private CarRentalContext db = new CarRentalContext();

        // GET: CarModelVM2
        public ActionResult Index()
        {
            return View(db.CarModelVM2.ToList());
        }

        // GET: CarModelVM2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModelVM2 carModelVM2 = db.CarModelVM2.Find(id);
            if (carModelVM2 == null)
            {
                return HttpNotFound();
            }
            return View(carModelVM2);
        }

        // GET: CarModelVM2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarModelVM2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarModelVM2Id,BrandList")] CarModelVM2 carModelVM2)
        {
            if (ModelState.IsValid)
            {
                db.CarModelVM2.Add(carModelVM2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carModelVM2);
        }

        // GET: CarModelVM2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModelVM2 carModelVM2 = db.CarModelVM2.Find(id);
            if (carModelVM2 == null)
            {
                return HttpNotFound();
            }
            return View(carModelVM2);
        }

        // POST: CarModelVM2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarModelVM2Id,BrandList")] CarModelVM2 carModelVM2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carModelVM2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carModelVM2);
        }

        // GET: CarModelVM2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModelVM2 carModelVM2 = db.CarModelVM2.Find(id);
            if (carModelVM2 == null)
            {
                return HttpNotFound();
            }
            return View(carModelVM2);
        }

        // POST: CarModelVM2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarModelVM2 carModelVM2 = db.CarModelVM2.Find(id);
            db.CarModelVM2.Remove(carModelVM2);
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
