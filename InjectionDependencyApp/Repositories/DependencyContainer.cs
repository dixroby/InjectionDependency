using Entities.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repositories;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddProductsRepository(
        this IServiceCollection services)
    {
        services.AddSingleton<IProductsRepository, ProductRepository>();
        return services;
    }
}