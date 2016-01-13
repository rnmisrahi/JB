using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [DataContract]
    class DivisionDetails
    {
        [DataMember]
        public int Dividend { get; set; }
        [DataMember]
        public int Divisor { get; set; }
        [DataMember]
        public string  Url { get; set; }
    }
}
