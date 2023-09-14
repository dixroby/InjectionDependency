using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Library
{
    public class ExampleService
    {   // Regla de detección de varios constructores:

        // el constructor que requiera mas inyeccion de dependencias es el que se llama.
        // al constructor que es mas legible(parámetros que se resuelven por Inyección de dependencias), es el que se llamara.
        // ademas en un constructor, todos los parametros tienen que ser resueltas
        // se llamara el que tiene mas parametros, incluido los que son obsionales.
        
        public ExampleService()
        {

        }

        public ExampleService(ILogger<ExampleService> logger)
        {

        }

        public ExampleService(FooService fooService, BarService barService)
        {

        }
        public ExampleService(ILogger<ExampleService> logger, IOptions<ExampleService> options)
        {
                
        }
        public ExampleService(ILogger<ExampleService> logger, IOptions<ExampleService> options, FooService fooService, BarService barService)
        {

        }
    }

}