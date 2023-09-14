using Entities;
using Entities.Interfaces;

namespace ConsoleApp
{
    internal class GetProductController
    {
        readonly IGetProductsInputPort _interactor;

        public GetProductController(IGetProductsInputPort interactor)
        {
            _interactor = interactor;
        }

        public void GetProduct()
        {
            Console.Write("Id de producto: ");
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
