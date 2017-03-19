using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.DI
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product Get(int id);
        Product Add(Product item);
        bool Update(Product item);
        bool Delete(int id);
    }
}