using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using WcfServices.DataModels;

namespace WcfServices.DataServices
{
    public class Queries
    {
        public void LinqToEntities()
        {
            using (var context = new DemoEntities())
            {
                var product = context.Products.FirstOrDefault();

                var product2 = (from p in context.Products
                                where p.CategoryId == 1
                                select p).FirstOrDefault<Product>();
            }
        }

        public void EntitySQLObjectQuery()
        {
            using (var context  = new DemoEntities())
            {
                //var categories = context.Categories;
                var sql = @"SELECT VALUE C 
                            FROM DemoEntities.Categories As C 
                            WHERE C.CategoryId =1";

                ObjectContext oContext = (context as IObjectContextAdapter).ObjectContext;

                ObjectQuery<Category> categories = oContext.CreateQuery<Category>(sql);

                Category category = categories.FirstOrDefault<Category>();
            }
        }

        public void NativeSQL()
        {
            using ( var db = new DemoEntities())
            {
                var products = db.Products.SqlQuery("SELECT * FROM Product");

                var product = products.FirstOrDefault();
            }
        }

        public void Start()
        {
            LinqToEntities();
            EntitySQLObjectQuery();
            NativeSQL();
        }
    }
}