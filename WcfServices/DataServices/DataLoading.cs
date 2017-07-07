using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServices.DataModels;
using System.Data.Entity;

namespace WcfServices.DataServices
{
    public class DataLoading
    {
        public void EagerLoading()
        {
            using (var db = new DemoEntities())
            {

                Product product = db.Products
                            .Include(x => x.Category)
                            .FirstOrDefault(x => x.ProdutId == 1);

            }

        }

        public void ExplicitLoading()
        {
            using (var db = new DemoEntities())
            {

                Category category = db.Categories.Find(1);

                db.Entry(category)
                    .Collection(x => x.Products)
                    .Query()
                    .Where(x => x.ProductName.Contains("Jeans"))
                    .Load();
            }
        }


        public void Load()
        {
            EagerLoading();

            ExplicitLoading();
        }
    }
}