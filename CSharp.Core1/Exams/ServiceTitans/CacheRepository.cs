using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams.ServiceTitans
{
    public class CacheRepository
    {
        

        private MemoryCache _cache = new MemoryCache("ServiceCache");

        public ServiceBase Get(ServiceNames serviceName)
        {
            if (_cache.Contains(serviceName.ToString()))
            {
                var item = (CacheItem)_cache[serviceName.ToString()];
                var service = (ServiceBase)item.Value;

                var policy = new CacheItemPolicy
                {
                    AbsoluteExpiration = DateTime.UtcNow.AddSeconds(service.Timeout)
                };

                _cache.Set(serviceName.ToString(), item, policy);

                Console.WriteLine("From Cache");
                return service;
            }
            else
            {
                ServiceBase service = ServiceFactory.Get(serviceName);

                var policy = new CacheItemPolicy
                {
                    AbsoluteExpiration = DateTime.UtcNow.AddSeconds(service.Timeout)
                };
                var cacheItem = new CacheItem(serviceName.ToString(), service);
                _cache.Set(serviceName.ToString(), cacheItem, policy);

                Console.WriteLine("New");
                return service;
            }

        }

       
    }
}
