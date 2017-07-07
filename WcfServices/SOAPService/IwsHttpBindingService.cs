using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServices.SOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IwsHttpBindingService" in both code and config file together.
    [ServiceContract]
    public interface IwsHttpBindingService
    {
        [OperationContract]
        void DoWork(string name,int age);
    }
}
