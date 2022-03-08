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
        /// M�todo encargado de inicializar el microservicio
        /// </summary>
        /// <param name="args">Par�metros adicionales para la ejecuci�n</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// M�todo encargado de crear el host del microservicio
        /// </summary>
        /// <param name="args">Par�metros adicionales para la ejecuci�n</param>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
