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
    [Authorize(Roles = "Admin, Employee")]
    public class ReceiveCarsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ReceiveCars
        public ActionResult Index()
        {
            var reservations = db.Reservations.Include(r => r.Branch).Include(r => r.Car);
            reservations = reservations.Where(r => r.ReservationStatus == ReservationStatus.InUse);
            return View(reservations.ToList());
        }

        // GET: ReceiveCars/Details/5
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

        // GET: ReceiveCars/Delete/5
        public ActionResult ReceiveIt(int? id)
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

        // POST: ReceiveCars/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ReceiveIt(Reservation reservation)
        {
            //reservation contains only ReservationId and kilometrage
            int id = reservation.ReservationId;
            int kilometrage = reservation.Car.Kilometrage;
            reservation = db.Reservations.Find(id);

                reservation.ReservationStatus = ReservationStatus.Closed;//Todo Consider late delivery
                reservation.DateReturned = DateTime.Now;
                Car car = db.Cars.Find(reservation.Car.CarId);
                car.Kilometrage = kilometrage;
                car.CarStatus = CarStatus.Available;

                db.Entry(reservation).State = EntityState.Modified;
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Added"] = string.Format("{0} Returned", car.Description);
                return RedirectToAction("Index", "Home");

                //db.Entry(reservation).State = EntityState.Modified;
                //TempData["Added"] = reservation.Car.CarModel.Description + " Receive";
                //return RedirectToAction("Index");
            
            //return View(reservation);

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
