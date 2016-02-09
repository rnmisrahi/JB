using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class Unit
    {
        [Range(1, int.MaxValue, ErrorMessage = "Select a Unit of measure please")]
        public int UnitId { get; set; }
        public string UnitName { get; set; }
    }
}