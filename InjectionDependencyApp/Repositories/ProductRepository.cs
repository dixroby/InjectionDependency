using Entities;
using MemoryDataSource;

namespace Repositories
{
    public class ProductRepository
    {
        readonly ProductsDataSource _productsDataSource;
        public ProductRepository(ProductsDataSource productsDataSource)
        {
            _productsDataSource = productsDataSource;
        }
        public Product GetProductByiD(int id)
        {
            return _productsDataSource.GetProducts().FirstOrDefault(x => x.Id == id);
        }
    }
}