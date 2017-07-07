using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams.ServiceTitans
{
    public class UserService : ServiceBase
    {
        public UserService()
        {
            ServiceName = ServiceNames.UserService.ToString();
            Timeout = 10;
        }

        public void DoOperation()
        {

        }
    }
}
