using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_EI_Polymorphism_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StamService" in both code and config file together.
    public class StamService : IStamService
    {
        public string GetMessage()
        {
            return "Message From Stam Service";
        }
    }
}
