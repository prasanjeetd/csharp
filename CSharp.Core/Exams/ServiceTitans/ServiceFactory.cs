using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams.ServiceTitans
{
    public class ServiceFactory
    {
        public static ServiceBase Get(ServiceNames serviceName)
        {
            if (serviceName == ServiceNames.UserService)
                return new UserService();
            else
                return new ServiceBase();
        }
    }
}
