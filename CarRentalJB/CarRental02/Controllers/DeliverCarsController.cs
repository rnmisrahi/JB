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
    [Authorize(Roles = "Admin,Employee")]
    public class DeliverCarsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DeliverCars
        public ActionResult Index()
        {
            var reservations = db.Reservations.Include(r => r.Branch).Include(r => r.Car);
            reservations = reservations.Where(r => r.ReservationStatus == ReservationStatus.Reserved);
            return View(reservations.ToList());
        }

        // GET: DeliverCars/Details/5
        public ActionResult Details(int? id)
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

        // GET: DeliverCars/DeliverIt/5
        public ActionResult DeliverIt(int? id)
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

        // POST: DeliverCars/DeliverIt/5
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult DeliverIt(int id)
        {
            Reservation reservation = db.Reservations.Find(id);
            reservation.ReservationStatus = ReservationStatus.InUse;
            Car car = db.Cars.Find(reservation.CarId);
            car.CarStatus = CarStatus.Rented;
            db.Entry(car).State = EntityState.Modified;
            db.Entry(reservation).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Added"] = string.Format("{0} Picked up", reservation.Car.Description);
            return RedirectToAction("Index", "Home");
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
