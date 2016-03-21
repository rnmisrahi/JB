using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarRental02.Models;
using System.Data.Entity.Infrastructure;

namespace CarRental02.Controllers
{
    public class CarTypesController : Controller
    {
        private CarRentalContext db = new CarRentalContext();

        // GET: CarTypes
        public ActionResult Index()
        {
            return View(db.CarTypes.ToList());
        }

        // GET: CarTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarType carType = db.CarTypes.Include(c => c.Files).SingleOrDefault(c => c.CarTypeId == id);
            //Instructor instructor = db.Instructors.Include(i => i.FilePaths).SingleOrDefault(i => i.ID == id);

            if (carType == null)
            {
                return HttpNotFound();
            }
            return View(carType);
        }

        // GET: CarTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarTypeId,CarCode,DailyPrice,DailyLatePrice")] CarType carType, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                if (upload != null && upload.ContentLength > 0)
                {
                    var avatar = new File
                    {
                        FileName = System.IO.Path.GetFileName(upload.FileName),
                        FileType = FileType.Avatar,
                        ContentType = upload.ContentType
                    };
                    using (var reader = new System.IO.BinaryReader(upload.InputStream))
                    {
                        avatar.Content = reader.ReadBytes(upload.ContentLength);
                    }
                    carType.Files = new List<File> { avatar };
                }
                db.CarTypes.Add(carType);
                db.SaveChanges();
                TempData["Added"] = carType.CarCode + " Added";
                return RedirectToAction("Index");
            }

            return View(carType);
        }

        // GET: CarTypes/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: CarTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        //public ActionResult Edit(CarType carType, HttpPostedFileBase upload)
        public ActionResult Edit(int? id, HttpPostedFileBase upload)
        {
            //if (ModelState.IsValid)
            //{
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var carType = db.CarTypes.Find(id);
            if (TryUpdateModel(carType, "",
               new string[] { "CarCode", "DailyPrice", "DailyLatePrice" }))
            {
                if (upload != null && upload.ContentLength > 0)
                {
                    if (carType.Files.Any(f => f.FileType == FileType.Avatar))
                    {
                        db.Files.Remove(carType.Files.First(f => f.FileType == FileType.Avatar));
                    }
                    var avatar = new File
                    {
                        FileName = System.IO.Path.GetFileName(upload.FileName),
                        FileType = FileType.Avatar,
                        ContentType = upload.ContentType
                    };
                    using (var reader = new System.IO.BinaryReader(upload.InputStream))
                    {
                        avatar.Content = reader.ReadBytes(upload.ContentLength);
                    }
                    carType.Files = new List<File> { avatar };

                    db.Entry(carType).State = EntityState.Modified;
                }
                db.Entry(carType).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Added"] = carType.CarCode + " Edited";
                return RedirectToAction("Index");
            }
            return View(carType);
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
            string carCode = carType.CarCode;
            db.CarTypes.Remove(carType);
            db.SaveChanges();
            TempData["Added"] = carCode + " Deleted";
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
