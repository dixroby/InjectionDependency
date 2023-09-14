using Library;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// el host implementa implicitamente, ILogger
var builder = Host.CreateApplicationBuilder();
builder.Services.AddLibraryServices();

using IHost AppHost = builder.Build();

ExampleService service = AppHost.Services.GetRequiredService<ExampleService>();

AppHost.Run();