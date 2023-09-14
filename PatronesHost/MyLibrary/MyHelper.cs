
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MyLibrary;
public class MyHelper
{
    /// 
    public static void DoSomeWork(IServiceProvider provider)
    {
        //cuando No trabajas con inyeción de dependencias
        ILogger logger = provider.GetRequiredService<ILoggerFactory>().CreateLogger("\tLogger Normal: ");

        // cuando si se usa inyección de dependencias
        ILogger<MyHelper> GenericLogger =  provider.GetRequiredService<ILogger<MyHelper>>();

        logger.LogInformation("Message from Logger");
        GenericLogger.LogInformation("Message from GenericLogger");
    }
}