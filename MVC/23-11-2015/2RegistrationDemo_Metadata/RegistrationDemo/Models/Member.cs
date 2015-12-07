using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required(ErrorMessage="You must enter your name")]
        [StringLength(12,MinimumLength=2,ErrorMessage="Name --> 2-12")]
        public string Name { get; set; }

        [Required(ErrorMessage="We have to know your seniority")]
        public int Seniority { get; set; }

        public bool IsProgrammer { get; set; }

        // [Required(ErrorMessage="Homeless??")]
        [Range(0,9999,ErrorMessage="Homeless??")]
        public int CityId { get; set; }

        //[Range(typeof(DateTime),
        //    DateTime.Today.AddYears(-100).ToShortDateString(),
        //    DateTime.Today.AddYears(-18).ToShortDateString(),
        //    ErrorMessage="Too old or too young")]
        [CustomValidation(typeof(CustomValidators),"IsValidBirthDate")]
        public DateTime BirthDate { get; set; }

        // [Required(ErrorMessage="Please, Agree to the conditions")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Please, Agree to the conditions")]
        public bool IsAcceptConditions { get; set; }
    }
}