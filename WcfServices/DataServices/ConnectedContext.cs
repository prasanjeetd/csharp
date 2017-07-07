using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServices.DataModels;

namespace WcfServices.DataServices
{
    public class ConnectedContext
    {
        public void CRUD_AutoDetectChanges()
        {
            using (var db = new DemoEntities())
            {
                db.Configuration.AutoDetectChangesEnabled = false;

                Product newProduct = new Product { ProductName = "Pepe Jeans", CategoryId = 2 };
                db.Products.Add(newProduct);

                Product existingProduct = db.Products.Find(1);
                existingProduct.ProductName = "Killer";

                Category existingCategory = db.Categories.Find(1);

                Category newCategory = new Category { CategoryName = "Jeans" };
                db.Categories.Add(newCategory);

                Customer customer = new Customer { FullName = "Billa Timepass", Address = "Pune" };
                db.Customers.Add(customer);

                var entries = db.ChangeTracker.Entries();

                db.ChangeTracker.DetectChanges();

                entries = db.ChangeTracker.Entries();

                //db.SaveChanges();
            }

        }

        public void CRUD_DisableProxy()
        {
            using (var db = new DemoEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;

                Product newProduct = new Product { ProductName = "Pepe Jeans", CategoryId = 2 };
                db.Products.Add(newProduct);

                Product existingProduct = db.Products.Find(1);
                existingProduct.ProductName = "Killer";

                Category existingCategory = db.Categories.Find(1);

                Category newCategory = new Category { CategoryName = "Jeans" };
                db.Categories.Add(newCategory);

                Customer customer = new Customer { FullName = "Billa Timepass", Address = "Pune" };
                db.Customers.Add(customer);

                var entries = db.ChangeTracker.Entries();

               // db.SaveChanges();
            }

        }
    }
}