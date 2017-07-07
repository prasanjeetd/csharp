using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using WcfServices.DataModels;

namespace WcfServices.DataServices
{
    public class ChangeTracking
    {
        public void ContextLifeCycle()
        {
            using (var db = new DemoEntities())
            {
                var product = db.Products.Find(1);

                CheckChangeTracking(db.ChangeTracker);

                Product newProduct = new Product { ProdutId = 2, ProductName = "Billa", CategoryId = 1 };
                db.Products.Add(newProduct);

                CheckChangeTracking(db.ChangeTracker);

                var category = db.Categories.Find(1);
                category.CategoryName = "Billa";

                CheckChangeTracking(db.ChangeTracker);

                var categoryToRemove = db.Categories.Find(1);
                db.Categories.Remove(categoryToRemove);

                CheckChangeTracking(db.ChangeTracker);

            }
        }

        public void CheckChangeTracking(DbChangeTracker changeTracker)
        {
            var entries = changeTracker.Entries();

            foreach (var entry in entries)
            {
                var name = entry.Entity.GetType().FullName;
                var state = entry.State;
            }

        }
    }
}