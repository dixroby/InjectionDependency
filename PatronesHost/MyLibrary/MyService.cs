using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MyLibrary
{
    public class MyService : IDisposable
    {
        readonly ILogger _Logger;
        readonly IConfiguration Configuration;

        public MyService(ILogger<MyService> logger, IConfiguration configuration)
        {
            _Logger = logger;
            Configuration = configuration;
        }
        public void LogMessage(string message) => _Logger.LogInformation(message);
        public void LogConfigKetMessage(string key) => _Logger.LogInformation($"LogConfigKetMessage: {0}", Configuration[key]);

        ///  Metodo para desechar, ID necesita desaserce
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}