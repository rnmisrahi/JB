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
    }
}