using Entities;
using Entities.Interfaces;

namespace UseCases
{
    internal class GetProductInteractor: IGetProductsInputPort
    {
        readonly IProductsRepository _repository;
        public GetProductInteractor(IProductsRepository repository)
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