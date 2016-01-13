using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We had to use the namespace of the Service Reference,
//  and sort of "extend" the class Person so we could override the ToString
// We could/should not modify the Person in the ServiceReferences.PersonReference
//  because that is overriten every time 
namespace Wcf_EI_Polymorphism_Client.PersonReference
{
    partial class Person
    {
        public override string ToString()
        {
            string s = String.Format("{0}: {1}", this.PersonId, this.PersonName);
            if (this is Teacher)
                return "Teacher: " + s;
            if (this is Secretary)
                return this.ToString();// "Secretary: " + s;
            return "Just a Generic Person" + s;
        }
    }
}
