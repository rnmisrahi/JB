using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_EI_Polymorphism_Server.Model;

namespace Wcf_EI_Polymorphism_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPersonService" in both code and config file together.
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        [ServiceKnownType(typeof(Teacher))]
        [ServiceKnownType(typeof(Secretary))]
        List<Person> GetAllPersons();

        [OperationContract]
        int AddPerson(string Name, Global.PersonType pType);

        [OperationContract]
        string Display(Person p);
    }
}
