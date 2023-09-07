using ID.Library;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddSingleton<IMessageWriter, MessageWriter>();

using IHost AppHost = Builder.Build();

//como estamos trabajando con consola se esta realizando de esta manera para su consumo.
var Writer = AppHost.Services.GetRequiredService<IMessageWriter>();

Writer.Write("Hello, world!");

AppHost.Run();