using Entities.Interfaces;
using UseCases;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddUseCases(
        this IServiceCollection services)
    {
        services.AddSingleton<IGetProductsInputPort, GetProductInteractor>();
        return services;
    }
}