using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int BranchId { get; set; }
        public string MemberId { get; set; }        
        public int CarId { get; set; }
        [Display(Name ="From Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FromDate { get; set; }
        [Display(Name = "To Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ToDate { get; set; }
        [Display(Name = "Date Returned")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateReturned { get; set; }
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