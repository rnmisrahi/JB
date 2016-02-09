using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClientXXX.InventoryService;

namespace WebClientXXX.Models
{
    public class InventoryContext
    {
        public List<Item> Items { get; set; }
        //public List<Item> Items = new List<Item>() { get; set;}
    }
}