
using CSharp.Core.Chapters.DI;
using CSharp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.EntityFramework
{
    public class CRUDOperations
    {

        public void ExecuteCRUD()
        {
            //using (var context = new EMarketEntities())
            //{
            //    var attribute = new AttributeMast();
            //    attribute.AttributeName = "Quantity";

            //    context.AttributeMasts.Add(attribute);
            //    context.SaveChanges();

            //}

            AttributeConsumer attribute = new AttributeConsumer(new AttributeService());
            attribute.Save("Billa");

        }

    }
}
