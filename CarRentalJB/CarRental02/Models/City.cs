using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CarRental02.Models.Validators;

namespace CarRental02.Models
{
    public class City
    {
        public int CityId { get; set; }
        [Display(Name = "City")]
        //[CustomValidation(typeof(CustomValidators), "ValidateCity")]
        [CityValidator]
        public string CityName { get; set; }
        public string Country { get; set; }
    }
}