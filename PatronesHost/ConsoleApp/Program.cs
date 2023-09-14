
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyLibrary;

CustomHost();

Console.Write("Press <enter> to finish");
void CustomHost()
{
    IServiceCollection services = new ServiceCollection();
    services.AddSingleton<MyService>();

    services.AddLogging(configure =>
    {
        configure.AddConsole();
        configure.AddDebug();
    });

    IServiceProvider serviceProvider = services.BuildServiceProvider();

    MyHelper.DoSomeWork(serviceProvider);
}