using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        [Display(Name ="Branch")]
        public int BranchId { get; set; }
        [Display(Name ="Member")]
        public string MemberId { get; set; }
        public int CarId { get; set; }
        [Display(Name = "From Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FromDate { get; set; }
        [Display(Name = "To Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ToDate { get; set; }
        [Display(Name = "Date Returned")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateReturned { get; set; }
        [Display(Name ="Status")]
        public ReservationStatus? ReservationStatus { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Member Member { get; set; }
        public virtual Car Car { get; set; }
    }

    public enum ReservationStatus
    {
        Reserved,
        Cancelled,
        InUse,
        Late,
        Closed
    }
}