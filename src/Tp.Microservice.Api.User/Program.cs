using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Tp.Microservice.Api.User
{
    /// <summary>
    /// Clase encargada de inicializar el microservicio
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Método encargado de inicializar el microservicio
        /// </summary>
        /// <param name="args">Parámetros adicionales para la ejecución</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Método encargado de crear el host del microservicio
        /// </summary>
        /// <param name="args">Parámetros adicionales para la ejecución</param>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
