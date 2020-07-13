using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.Models;

namespace WCFService
{
    public class ProductService : IProductService
    {

        public List<Product> GetAll()
        {
            return new List<Product>
           {
               new Product { ProductId = 1, ProductName = "Bilgisayar", ProductDescription = "Intel Core i7", ProductPrice = 7500, ProductIsActive = true },
               new Product { ProductId = 2, ProductName = "Cep Telefonu", ProductDescription = "IPhone X", ProductPrice = 9000, ProductIsActive = true },
               new Product { ProductId = 3, ProductName = "Çamaşır Makinesi", ProductDescription = "Arçelik", ProductPrice = 4500, ProductIsActive = true }
           };
        }

        public Product GetOne()
        {
            return new Product { ProductId = 1, ProductName = "Bilgisayar", ProductDescription = "Intel Core i7", ProductPrice = 7500, ProductIsActive = true };
        }
    }
}
