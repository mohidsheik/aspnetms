using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Catalog.API.Entities

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productcollection)
        {
            bool existsProduct = productcollection.Find(p => true).Any();
            if (!existsProduct)
            {
                productcollection.InsertManyAsync(GetDefaultProducts());
            }
        }

        private static IEnumerable<Product> GetDefaultProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name ="Iphone",
                    Description="Iphone from apple",
                    Category ="Phone",
                    ImageFile ="iphone.png",
                    Summary = "Latest fastest phone",
                    Price = 999.99M
                },
                new Product()
                {
                    Name ="POCO MX",
                    Description="Poco from MI",
                    Category ="Phone",
                    ImageFile ="poc.png",
                    Summary = "Slimest fastest phone",
                    Price = 299.99M
                }
            };
        }
    }
}
