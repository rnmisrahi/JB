using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental02.Models
{
    public class Car
    {
        public int CarId { get; set; }
        [Display(Name = "Car Type")]
        public int CarTypeId { get; set; }
        [Display(Name = "Branch")]
        public int BranchId { get; set; }
        public string CarColor { get; set; }
        public int Kilometrage { get; set; }
        public string Picture { get; set; }
        [Required]
        public string Plates { get; set; }
        [Display(Name = "Status")]
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