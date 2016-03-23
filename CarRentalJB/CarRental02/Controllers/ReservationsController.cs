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
    public class ReservationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private double rentalEstimate(double dailyPrice, DateTime startDate, DateTime endDate)
        {
            TimeSpan ts = endDate - startDate;
            if (ts.Days <= 0)
                return 0;
            return ts.Days * dailyPrice;
        }

        // GET: Reservations
        public ActionResult Index(string FilterCarCode, string FilterCity, string CityId, string StartDate, string EndDate)
        {
            ReservationViewModel rvm = new ReservationViewModel();
            try {
                rvm.StartDate = DateTime.Parse(StartDate);
                rvm.EndDate = DateTime.Parse(EndDate);
            }
            catch (Exception)//Defensive programming
            {
                rvm.StartDate = Common.Tomorrow();
                rvm.EndDate = Common.DayAfterTomorrow();
            }
            //rvm.CarData = db.Cars.ToList();
            //var reservations = db.Reservations.Include(r => r.Branch).Include(r => r.Car);
            var cars = db.Cars.Include(c => c.Branch).Include(c => c.CarType);
            if (!String.IsNullOrWhiteSpace(FilterCarCode))
            {
                cars = cars.Where(s => s.CarType.CarCode == FilterCarCode);
            }
            //ViewBag.CarCodeFilter = FilterCarCode;
            if (!String.IsNullOrWhiteSpace(CityId))
            {
                int cityId;
                if (int.TryParse(CityId, out cityId))
                {
                    cars = cars.Where(s => s.Branch.City.CityId==cityId);
                }
            }
            ViewBag.FilterCity = FilterCity;
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "CityName");
            var distinctCarCodes = (from c in db.CarTypes
                                    select new { CarCode = c.CarCode }).Distinct();
            ViewBag.CarCodeId = new SelectList(distinctCarCodes, "CarCode", "CarCode");
            rvm.CarData = cars.ToList();
            return View(rvm);
        }

        // GET: Reservations/Details/5
        public ActionResult Details(int? id, string StartDate, string EndDate)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationDbContext db = new ApplicationDbContext();

            Car car = db.Cars.Find(id);
            //CarType carType = db.CarTypes.Include(c => c.Files).SingleOrDefault(c => c.CarTypeId == id);
            //Car car = db.Cars.Include(c => c.Files).SingleOrDefault(c => c.CarTypeId == id);

            CarViewModel cvm = new CarViewModel();
            cvm.CarData = car;
            cvm.StartDate = DateTime.Parse(StartDate);
            cvm.EndDate = DateTime.Parse(EndDate);
            return View(cvm);
        }

        // GET: Reservations/Create
        public ActionResult Create()
        {
            ViewBag.BranchId = new SelectList(db.Branches, "BranchId", "BranchName");
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "CityName");

            ViewBag.StartDate = Common.Tomorrow();
            ViewBag.EndDate = Common.DayAfterTomorrow();
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReservationId,BranchId,MemberId,CarId,FromDate,ToDate,DateReturned,ReservationStatus")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                db.Reservations.Add(reservation);
                db.SaveChanges();
                //TempData["Added"] = reservation.Car.CarType.Description + " at " + reservation.Car.CarType.Description + " Added";
                return RedirectToAction("Index");
            }

            ViewBag.BranchId = new SelectList(db.Branches, "BranchId", "BranchName", reservation.BranchId);
            //Todo: We have to come up with a field different from CarColor
            //ViewBag.CarId = new SelectList(db.Cars, "CarId", "CarColor", reservation.CarId);
            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public ActionResult Edit(int? CarId, DateTime StartDate, DateTime EndDate, double Quote)
        {
            if (CarId == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Car car = db.Cars.Find(CarId);
            if (car == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            
            Reservation reservation = new Reservation();
            reservation.CarId = CarId.Value;
            reservation.BranchId = car.BranchId;//This may be redundant because car has the branch field in it
            reservation.FromDate = StartDate;
            reservation.ToDate = EndDate;
            reservation.ReservationStatus = ReservationStatus.Reserved;
            db.Reservations.Add(reservation);
            db.SaveChanges();

            ViewBag.BranchId = new SelectList(db.Branches, "BranchId", "BranchName", reservation.BranchId);
            ViewBag.CarId = new SelectList(db.Cars, "CarId", "CarColor", reservation.CarId);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReservationId,BranchId,MemberId,CarId,FromDate,ToDate,DateReturned,ReservationStatus")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reservation).State = EntityState.Modified;
                db.SaveChanges();
                //TempData["Added"] = reservation.Car.CarType.Description + " at " + reservation.Car.CarType.Description + " Edited";
                return RedirectToAction("Index");
            }
            ViewBag.BranchId = new SelectList(db.Branches, "BranchId", "BranchName", reservation.BranchId);
            ViewBag.CarId = new SelectList(db.Cars, "CarId", "CarColor", reservation.CarId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reservation reservation = db.Reservations.Find(id);
            db.Reservations.Remove(reservation);
            db.SaveChanges();
            //TempData["Added"] = reservation.Car.CarType.Description + " at " + reservation.Car.CarType.Description + " Deleted";
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
