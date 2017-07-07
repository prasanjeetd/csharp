using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams.ServiceTitans
{
    public class ServiceBase
    {
        public string ServiceName { get; set; }

        public int Timeout { get; set; }

        public ServiceBase()
        {
            ServiceName = ServiceNames.ServiceBase.ToString();
            Timeout = 10;
        }

    }
}
