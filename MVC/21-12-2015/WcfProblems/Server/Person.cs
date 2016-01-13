using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int PersonID { get; set; }
        [DataMember]
        public string PersonName { get; set; }
        public int Amount { get; set; }
        [DataMember]
        private int myNumber=987;

        
        public override string ToString()
        {
            return string.Format("{0} ==> {1}, {2}", PersonID, PersonName, Amount);
        }
    }
}
