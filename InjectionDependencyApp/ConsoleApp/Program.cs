// See https://aka.ms/new-console-template for more information
using Entities;
using UseCases;

Console.WriteLine("Id de producto: ");

int Id = int.Parse(Console.ReadLine());

GetProductInteractor interactor= new GetProductInteractor();
Product product= interactor.GetProductById(Id);



if (product == null)
{
    Console.WriteLine("Producto no encontrado");
}
else
{
    Console.WriteLine($"{product.Id}: {product.Name}, {product.UnitPrice}, {product.unitsInStok}");
}
