using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataService" in both code and config file together.
    public class DataService : IDataService
    {
        public List<Person> GetAllMembers()
        {
            return Repository.Members;
        }

        public Person GetPerson()
        {
            return new Person {
                PersonID = 111,
                PersonName = "Gershon",
                Amount = 2400,
            };
        }

        public void Swap(ref int x, ref int y)
        {
            int z=x;
            x = y;
            y = z;
        }
    }
}
