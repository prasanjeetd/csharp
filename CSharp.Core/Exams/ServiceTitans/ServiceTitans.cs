using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Core.Exams.ServiceTitans
{
    public class ServiceTitans
    {
        public void Start()
        {
            CacheRepository cache = new CacheRepository();
            UserService userService = (UserService)cache.Get(ServiceNames.UserService);

            //Should Fetch
            Thread.Sleep(2000);
             userService = (UserService)cache.Get(ServiceNames.UserService);

            //Should Fetch
            Thread.Sleep(9000);
            userService = (UserService)cache.Get(ServiceNames.UserService);

            //Should Fetch
            Thread.Sleep(11000);
            userService = (UserService)cache.Get(ServiceNames.UserService);

            Console.WriteLine("ServiceTitans");
            Console.ReadLine();
        }

    }
}
