using MemoryDataSource;
using Repositories;
using UseCases;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddDIServices(
        this IServiceCollection services)
    {
        services.AddSingleton<ProductRepository>();
        services.AddSingleton<ProductsDataSource>();
        services.AddSingleton<GetProductInteractor>();
        return services;
    }
}
