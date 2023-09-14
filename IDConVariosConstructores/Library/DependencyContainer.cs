
using Library;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddLibraryServices(this IServiceCollection services)
        {
            services.AddSingleton<ExampleService>();
            services.AddOptions<ExampleOptions>();
            return services;
        }
    }
}
