using CarRental02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarRental02.ViewModels
{
    [NotMapped]
    public class ReservationRequest
    {
        public int ReservationRequestId { get; set; }
        public string CarCode { get; set; }
        public int BranchId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        virtual public Branch Branch { get; set; }
    }
}