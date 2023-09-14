using Entities.Interfaces;
using MemoryDataSource;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddMemoryProductsDataSource(
        this IServiceCollection services)
    {
        services.AddSingleton<IProductsDataSource, MemoryProductsDataSource>();
        return services;
    }
}