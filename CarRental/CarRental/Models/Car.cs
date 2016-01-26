using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public int  CarTypeId { get; set; }
        public int BranchId { get; set; }
        public string CarColor { get; set; }
        public int Kilometrage { get; set; }
        public string Picture { get; set; }
        public string Plates { get; set; }
        public CarStatus? CarStatus { get; set; }
        public string Comments { get; set; }

        public virtual CarType CarType { get; set; }
        public virtual Branch Branch { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }

    public enum CarStatus
    {
        Available,
        Rented,
        InRepair,
        Other
    }


}