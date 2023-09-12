using Entities;

namespace Repositories
{
    public class ProductRepository
    {
        readonly List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name ="Azúcar", UnitPrice = 17.4m, unitsInStok = 13},
            new Product { Id = 2, Name ="Cola", UnitPrice = 13.4m, unitsInStok = 11},
            new Product { Id = 3, Name ="Leche", UnitPrice = 11.1m, unitsInStok = 19},
        };
        public Product GetProductByiD(int id)
        {
            return products.SingleOrDefault(p => p.Id == id);
        }
    }
}