using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarRental02.Models;

namespace CarRental02.Controllers
{
    public class CarBrandsController : Controller
    {
        private CarRentalContext db = new CarRentalContext();

        // GET: CarBrands
        public ActionResult Index()
        {
            return View(db.CarBrands.OrderBy(b=>b.BrandName).ToList());
        }

        // GET: CarBrands/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarBrand carBrand = db.CarBrands.Find(id);
            if (carBrand == null)
            {
                return HttpNotFound();
            }
            return View(carBrand);
        }

        // GET: CarBrands/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarBrands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarBrandId,BrandName")] CarBrand carBrand)
        {
            if (ModelState.IsValid)
            {
                db.CarBrands.Add(carBrand);
                TempData["Added"] = carBrand.BrandName + " Added";
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carBrand);
        }

        // GET: CarBrands/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarBrand carBrand = db.CarBrands.Find(id);
            if (carBrand == null)
            {
                return HttpNotFound();
            }
            return View(carBrand);
        }

        // POST: CarBrands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarBrandId,BrandName")] CarBrand carBrand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carBrand).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Added"] = carBrand.BrandName + " Edited";
                return RedirectToAction("Index");
            }
            return View(carBrand);
        }

        // GET: CarBrands/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarBrand carBrand = db.CarBrands.Find(id);
            if (carBrand == null)
            {
                return HttpNotFound();
            }
            return View(carBrand);
        }

        // POST: CarBrands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarBrand carBrand = db.CarBrands.Find(id);
            db.CarBrands.Remove(carBrand);
            db.SaveChanges();
            TempData["Added"] = carBrand.BrandName + " Deleted";
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
