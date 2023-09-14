using Entities;
using Entities.Interfaces;

namespace JsonDataSource
{
    internal class JsonProductsDataSource: IProductsDataSource
    {
        public List<Product> Products;
        public List<Product> GetProducts()
        {
            Products = new List<Product>()
            {
                new Product { Id = 1, Name ="Jamon", UnitPrice = 17.4m, unitsInStok = 13},
                new Product { Id = 2, Name ="Carne", UnitPrice = 13.4m, unitsInStok = 11},
                new Product { Id = 3, Name = "Azúcar", UnitPrice = 11.1m, unitsInStok = 19 },
            };
            return Products;
        }
    }
}