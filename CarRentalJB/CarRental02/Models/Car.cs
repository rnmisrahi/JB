﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental02.Models
{
    public class Car
    {
        public int CarId { get; set; }
        [Display(Name = "Car Type")]
        public int CarTypeId { get; set; }
        [Display(Name = "Branch")]
        public int BranchId { get; set; }

        [Display(Name ="Model")]
        public int? CarModelId { get; set; }
        public Gear? Gear { get; set; }
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
        public virtual CarModel CarModel { get; set; }

        [NotMapped]
        [Display(Name = "Brand-Model")]
        public string Description //This is needed in Index and to briefly display what was added/modified
        {
            get
            {
                try
                {
                    using (ApplicationDbContext db = new ApplicationDbContext())
                    {
                        var aModel = db.CarModels.Find(CarModelId);
                        //return string.Format("{0} - {1} ({2})", aModel.CarBrand.BrandName, aModel.ModelName, aModel.Pl);
                        return string.Format("{0} - {1} ({2})", aModel.CarBrand.BrandName, aModel.ModelName, Plates);
                    }
                }
                catch (Exception)
                {
                    return "No Model Found";
                }
            }
        }

        public virtual ICollection<Reservation> Reservations { get; set; }
        //public virtual ICollection<File> Files { get; set; }
    }

    public enum CarStatus
    {
        Available,
        Rented,
        UnderRepair,
        Other
    }


}