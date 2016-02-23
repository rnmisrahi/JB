using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using FluentValidation.Attributes;

namespace CarRental02.Models
{
    [Validator(typeof(BrandValidator))]
    public class CarBrand
    {
        public int CarBrandId { get; set; }
        [Display(Name = "Brand")]
        [CustomValidation(typeof(BrandValidator), "ValidateBrandName")]
        public string BrandName { get; set; }

        public virtual ICollection<CarModel> CarModels { get; set; }
    }
}