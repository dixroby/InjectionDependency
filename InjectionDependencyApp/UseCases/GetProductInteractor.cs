using Entities;
using Repositories;

namespace UseCases
{
    public class GetProductInteractor
    {
        readonly ProductRepository repository = new ProductRepository();
        public Product GetProductById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El id debe ser mayor que 0");
            return repository.GetProductByiD(id);
        } 
    }
}