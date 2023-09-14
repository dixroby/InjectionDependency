using Entities;
using Entities.Interfaces;

namespace Repositories
{
    internal class ProductRepository: IProductsRepository
    {
        readonly IProductsDataSource _productsDataSource;
        public ProductRepository(IProductsDataSource productsDataSource)
        {
            _productsDataSource = productsDataSource;
        }
        public Product GetProductByiD(int id)
        {
            return _productsDataSource.GetProducts().FirstOrDefault(x => x.Id == id);
        }
    }
}