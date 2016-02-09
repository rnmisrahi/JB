using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class CustomValidators
    {

        public static ValidationResult IsItemIdUnique(string itemId)
        {

            return ValidationResult.Success;
        }
    }
}