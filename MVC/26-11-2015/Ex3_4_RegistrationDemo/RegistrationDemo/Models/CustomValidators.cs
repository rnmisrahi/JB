using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationDemo.Models
{
    public class CustomValidators
    {
        public static ValidationResult IsValidBirthDate(DateTime value)
        {
            if (DateTime.Today.Year - value.Year < 18)
            {
                return new ValidationResult("You are too young. Try tomorrow!");
            }
            else if (DateTime.Today.Year - value.Year > 100)
            {
                return new ValidationResult("You are too old. Have you great-grandsons??");
            }
            return ValidationResult.Success;
        }

        public static ValidationResult IsValid_BirthDate_Seniority(Member member)
        {
            if (DateTime.Today.Year - member.BirthDate.Year - member.Seniority < 14)
            {
                return new ValidationResult("We count your seniority from age of 14 only");
            }
            return null;

        }
    }
}