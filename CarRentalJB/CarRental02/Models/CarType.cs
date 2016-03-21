using CarRental02.Models.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarRental02.Models
{
    public enum Gear
    {
        Automatic, Shift
    }

    public class CarType
    {
        public int CarTypeId { get; set; }
        private ApplicationDbContext db = new ApplicationDbContext();

        [Display(Name ="Car Code")]
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(1)]
        //[CustomValidation(typeof(CustomValidators), "ValidateCarCode")]//This worked when adding, but not when editing
        [CarCodeValidator]
        public string CarCode { get; set; }

        //[Required]
        //[Display(Name ="Model")]
        //public int CarModelId { get; set; }

        [Display(Name ="$/Day")]
        [DataType(DataType.Currency)]
        public double DailyPrice { get; set; }
        [Display(Name ="$/Day Late")]
        [DataType(DataType.Currency)]
        public double DailyLatePrice { get; set; }
        public string Picture { get; set; }
        //public Gear? Gear { get; set; }
        //[NotMapped]
        //[Display(Name = "Brand-Model")]
        //public string Description {
        //    get
        //    {
        //        var aModel = db.CarModels.Find(CarModelId);
        //        return string.Format("Code: {0} - Brand: {1} - Model:{2}", CarCode, aModel.CarBrand.BrandName, 
        //            aModel.ModelName);
        //    }
        //}

        //public virtual CarModel CarModel { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<File> Files { get; set; }

    }
}