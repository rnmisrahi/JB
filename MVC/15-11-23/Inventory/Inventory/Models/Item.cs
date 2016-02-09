using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Item
    {
        [Required]
        //[Display(AutoGenerateField=true)]
        [RegularExpression(@"^[A-Z,a-z]{2}\d{4}[A-Z,a-z]{2}$")]
        public string Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 20 characters")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Prod. Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public DateTime ProductionDate { get; set; }

        [Required]
        [Display(Name = "Qty")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
        public int CurrentQuantity { get; set; }

        [Display(Name="Min Qty")]
        [Range(0, int.MaxValue, ErrorMessage = "Minimum quantity cannot be negative")]
        public int MinimumQuantity { get; set; }

        [Display(Name="Max Qty")]
        [Range(0, int.MaxValue, ErrorMessage = "Maximum quantity cannot be negative")]
        public int MaximumQuantity { get; set; }

        [Required]
        public int UnitId { get; set; }

        public bool saveChangedItem()
        {
            Item item = ItemRepository.Items.FirstOrDefault(x => x.Id == this.Id);
            if (item != null)
            {
                item.Name = this.Name;
                item.ProductionDate = this.ProductionDate;
                item.CurrentQuantity = this.CurrentQuantity;
                item.MinimumQuantity = this.MinimumQuantity;
                item.MaximumQuantity = this.MaximumQuantity;
                item.UnitId = this.UnitId;
                return true;                 
            }
            return false;
        }
    }
}