using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Wcf_EI_Polymorphism_Server.Model
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string Phone { get; set; }
    }
}
