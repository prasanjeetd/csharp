using CSharp.Core.Chapters.DI;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Terminal.DI
{
    public class DIResolver
    {
        public void Resolve()
        {
            var container = new UnityContainer();
            container.RegisterType<IAttributeServices, AttributeService>();

            AttributeConsumer ac = container.Resolve<AttributeConsumer>();
        }

        public void ResolveByConfig()
        {
            var container = new UnityContainer();
            var section =(UnityConfigurationSection) ConfigurationManager.GetSection("unity");
           // section.Containers.Default.Configure(container);

            container.LoadConfiguration();

            AttributeConsumer ac = container.Resolve<AttributeConsumer>();
        }
    }
}
