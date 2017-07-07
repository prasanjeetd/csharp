using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServices.DataModels;

namespace WcfServices.DataServices
{
    public class Projections
    {
        public void NestedQueries()
        {
            using( var db = new DemoEntities())
            {
                var nestedResult = (from c in db.Categories
                                   from p in c.Products
                                   where c.CategoryId == 1
                                   select new
                                   {
                                       p.ProductName,
                                       c
                                   }).ToList();
            }

        }

        public void GetDBEntityEntry()
        {
            using( var db = new DemoEntities())
            {
                var product = db.Products.Find(1);

                product.ProductName = "Timepass";

                var productEntry = db.Entry(product);

                string fullName = productEntry.Entity.GetType().FullName;
                System.Data.Entity.EntityState state = productEntry.State;

                foreach(var propertyName in productEntry.CurrentValues.PropertyNames)
                {
                    var currentValue = productEntry.CurrentValues[propertyName];

                    var originalValue= productEntry.OriginalValues[propertyName];
                }
            }

        }

        public void NoTracking()
        {
            using ( var db = new DemoEntities())
            {
                var category = db.Categories.AsNoTracking()
                                    .Where(x => x.CategoryId == 1) 
                                    .SingleOrDefault();

                var categoryEntry = db.Entry(category);

            }
        }

        public void Start()
        {
            NestedQueries();
            GetDBEntityEntry();
            NoTracking();
        }
    }
}