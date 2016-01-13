using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wcf_EI_Polymorphism_Client.PersonReference
{
    partial class Secretary
    {
        public override string ToString()
        {
            return "This is " + PersonName + ", a secretary";
        }
    }
}
