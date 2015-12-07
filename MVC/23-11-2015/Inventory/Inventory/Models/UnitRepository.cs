using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public static class UnitRepository
    {
        public static List<Unit> Units = new List<Unit>
        {
            new Unit{UnitId=1, UnitName="each"},
            new Unit{UnitId=2, UnitName="kg"},
            new Unit{UnitId=3, UnitName="gr"},
            new Unit{UnitId=4, UnitName="meter"},
            new Unit{UnitId=5, UnitName="lb"},
            new Unit{UnitId=6, UnitName="liter"},
            new Unit{UnitId=7, UnitName="gallon"},
        };
    }
}