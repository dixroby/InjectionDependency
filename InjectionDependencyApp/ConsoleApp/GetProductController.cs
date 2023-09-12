using Entities;
using UseCases;

namespace ConsoleApp
{
    public class GetProductController
    {
        readonly GetProductInteractor _interactor;

        public GetProductController(GetProductInteractor interactor)
        {
            _interactor = interactor;
        }

        public void GetProduct()
        {
            Console.WriteLine("Id de producto: ");
            int Id = int.Parse(Console.ReadLine());

            Product product = _interactor.GetProductById(Id);
            if (product == null)
            {
                Console.WriteLine("Producto no encontrado");
            }
            else
            {
                Console.WriteLine($"{product.Id}: {product.Name}, {product.UnitPrice}, {product.unitsInStok}");
            }
        }
    }
}
