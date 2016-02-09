using Client_Config.InventoryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client_Config.Models
{
    public class ItemAdded
    {
        public Item Item { get; set; }
        public int QuantityAdded { get; set; }
    }
}