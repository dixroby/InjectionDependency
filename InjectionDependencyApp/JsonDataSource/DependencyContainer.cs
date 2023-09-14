using Entities.Interfaces;
using JsonDataSource;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddJsonProductsDataSource(
        this IServiceCollection services)
    {
        services.AddSingleton<IProductsDataSource, JsonProductsDataSource>();
        return services;
    }
}