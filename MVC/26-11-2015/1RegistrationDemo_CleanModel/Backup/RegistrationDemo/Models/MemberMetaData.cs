using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    [MetadataType(typeof(MemberMetadata))]
    public partial class Member 
    { 
    
    }
    
    public class MemberMetadata
    {
        [Required(ErrorMessage = "You must enter your name")]
        [StringLength(12, MinimumLength = 2, ErrorMessage = "Name --> 2-12")]
        public string Name { get; set; }

        [Required(ErrorMessage = "We have to know your seniority")]
        public int Seniority { get; set; }

        [Range(0, 9999, ErrorMessage = "Homeless??")]
        public int CityId { get; set; }

        [CustomValidation(typeof(CustomValidators), "IsValidBirthDate")]
        public DateTime BirthDate { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Please, Agree to the conditions")]
        public bool IsAcceptConditions { get; set; }
    }
}