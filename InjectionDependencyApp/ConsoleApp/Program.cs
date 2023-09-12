// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using MemoryDataSource;
using Repositories;
using UseCases;



GetProductController interactor = new GetProductController(
    new GetProductInteractor(
        new ProductRepository(new ProductsDataSource()
        )
    )
  );

interactor.GetProduct();