namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddDIServices(
        this IServiceCollection services)
    {
        services.AddProductsRepository();
        services.AddJsonProductsDataSource();
        services.AddMemoryProductsDataSource();
        services.AddUseCases();
        return services;
    }
}