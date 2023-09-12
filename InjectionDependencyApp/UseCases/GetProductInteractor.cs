using Entities;
using Repositories;

namespace UseCases
{
    public class GetProductInteractor
    {
        readonly ProductRepository _repository;
        public GetProductInteractor(ProductRepository repository)
        {
            _repository = repository;
        }
        public Product GetProductById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El id debe ser mayor que 0");
            return _repository.GetProductByiD(id);
        }
    }
}