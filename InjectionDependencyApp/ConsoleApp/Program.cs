// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

/// con servicios
/// ==================================================================

// service collection es donde se agrega los servicios
//IServiceCollection serviceCollection = new ServiceCollection();

//// Registrar repository
//serviceCollection.AddSingleton<ProductRepository>();
//serviceCollection.AddSingleton<ProductsDataSource>();
//serviceCollection.AddSingleton<GetProductInteractor>();
//serviceCollection.AddSingleton<GetProductController>();

//// DependencyInjection, construye el service provider
//IServiceProvider serviceProvider =  serviceCollection.BuildServiceProvider();

//// Pedir el servicio que deseas
//GetProductController controller = serviceProvider.GetService<GetProductController>();

//controller.GetProduct();

/// con HOST
/// ==================================================================
//HostApplicationBuilder builder = Host.CreateApplicationBuilder();

//builder.Services.AddSingleton<ProductRepository>();
//builder.Services.AddSingleton<ProductsDataSource>();
//builder.Services.AddSingleton<GetProductInteractor>();
//builder.Services.AddSingleton<GetProductController>();

//using IHost AppHost = builder.Build();

//var controller = AppHost.Services.GetRequiredService<GetProductController>();

//controller.GetProduct();

/// ==================================================================
// IoC  - se crea un proyecto para agregar los servicios.
/// ==================================================================

HostApplicationBuilder builder = Host.CreateApplicationBuilder();

builder.Services.AddDIServices();
builder.Services.AddSingleton<GetProductController>();

using IHost AppHost = builder.Build();

GetProductController controller = AppHost.Services.GetRequiredService<GetProductController>();
controller.GetProduct();