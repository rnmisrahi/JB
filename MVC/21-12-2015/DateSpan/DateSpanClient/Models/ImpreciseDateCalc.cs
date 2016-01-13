using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DateSpanClient.ImpreciseServiceReference1;

namespace DateSpanClient.Models
{
    public class ImpreciseDateCalc
    {
        public string DOB { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public int? Age { get; set; }
        public int? Years { get; set; }

        public int? PreciseAge { get; set; }
        public int? PreciseYears { get; set; }
    }
}