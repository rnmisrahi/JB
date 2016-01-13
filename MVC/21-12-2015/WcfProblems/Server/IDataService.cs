using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataService" in both code and config file together.
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        Person GetPerson();

        [OperationContract]
        void Swap(ref int x, ref int y);
        [OperationContract]
        [ServiceKnownType(typeof(Teacher))]
        [ServiceKnownType(typeof(Secretary))]
        List<Person> GetAllMembers();
    }
}
