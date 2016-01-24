using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersApp.Model
{
    public class Member2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CityID { get; set; }
        public bool IsActive { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", ID, Name);
        }
    }
        
}
