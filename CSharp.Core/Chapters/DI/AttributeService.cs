using CSharp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DI
{
    public class AttributeService : IAttributeServices
    {
        public void Save(string name)
        {
            using (var context = new EMarketEntities())
            {
                var attribute = new AttributeMast();
                attribute.AttributeName = name;

                context.AttributeMasts.Add(attribute);
                context.SaveChanges();

            }

        }
    }
}
