using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wcf_EI_Polymorphism_Server.Model
{
    public class Teacher:Person
    {
        public int Seniority { get; set; }
    }
}
