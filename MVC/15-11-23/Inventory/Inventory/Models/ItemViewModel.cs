using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Inventory.Models
{
    public class ItemViewModel
    {
        public Item ItemData { get; set; }
        [Display(Name = "Unit")]
        public string UnitName { get; set; }
        public List<Unit> Units { get; set; }
    }
}