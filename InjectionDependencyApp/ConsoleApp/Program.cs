// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using MemoryDataSource;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using UseCases;

// service collection es donde se agrega los servicios
IServiceCollection serviceCollection = new ServiceCollection();

// Registrar repository
serviceCollection.AddSingleton<ProductRepository>();
serviceCollection.AddSingleton<ProductsDataSource>();
serviceCollection.AddSingleton<GetProductInteractor>();
serviceCollection.AddSingleton<GetProductController>();

// DependencyInjection, construye el service provider
IServiceProvider serviceProvider =  serviceCollection.BuildServiceProvider();

// Pedir el servicio que deseas
GetProductController controller = serviceProvider.GetService<GetProductController>();

controller.GetProduct();