using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public static class ItemRepository
    {

        public static List<Item> Items = new List<Item>
        {
            new Item{Id="hp4201CL", Name="HP Clr Printer 4201", 
                ProductionDate= DateTime.Parse("03/23/2012"),CurrentQuantity=3,
                MinimumQuantity=2,MaximumQuantity=5, UnitId=1},
            new Item{Id="hp4200BW", Name="HP B/W Printer 4200", 
                ProductionDate= DateTime.Parse("05/13/1987"),CurrentQuantity=7,
                MinimumQuantity=2,MaximumQuantity=10, UnitId=1},
            new Item{Id="as123410", Name="Asus Laptop 10GB Ram", 
                ProductionDate= DateTime.Parse("10/3/2015"),CurrentQuantity=2,
                MinimumQuantity=2,MaximumQuantity=4, UnitId=1},
            new Item{Id="ms1010WW", Name="MS Windows 10", 
                ProductionDate= DateTime.Parse("04/02/2015"),CurrentQuantity=1,
                MinimumQuantity=1,MaximumQuantity=5, UnitId=1},            
            new Item{Id="tv1234YG", Name="Yoghurt", 
                ProductionDate= DateTime.Parse("10/02/2015"),CurrentQuantity=23,
                MinimumQuantity=5,MaximumQuantity=50,UnitId=3},            
        };

    }
}