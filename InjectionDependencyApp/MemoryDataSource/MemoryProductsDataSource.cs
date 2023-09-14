using Entities;
using Entities.Interfaces;

namespace MemoryDataSource
{
    internal class MemoryProductsDataSource: IProductsDataSource
    {
        public List<Product> Products;
        public List<Product> GetProducts()
        {
            Products = new List<Product>()
            {
                new Product { Id = 1, Name ="Cafe", UnitPrice = 17.4m, unitsInStok = 13},
                new Product { Id = 2, Name ="Cola", UnitPrice = 13.4m, unitsInStok = 11},
                new Product { Id = 3, Name = "Leche", UnitPrice = 11.1m, unitsInStok = 19 },
            };
            return Products;
        }
    }
}