using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Tp.Microservice.Api.User.Configuration.Startup.DbContext
{
    /// <summary>
    /// Clase encargada de configurar el contexto de base de datos
    /// </summary>
    public static class DbContext
    {
        /// <summary>
        /// Método encargado de configurar el contexto de base de datos
        /// </summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors</param>
        /// <param name="configuration">Represents a set of key/value application configuration properties</param>
        public static void AddMicroserviceContext<TDbContext>(this IServiceCollection services, IConfiguration configuration) where TDbContext : Microsoft.EntityFrameworkCore.DbContext
        {
            var migration = typeof(User.Startup).GetTypeInfo().Assembly.GetName().Name;

            services.AddDbContext<TDbContext>(x =>
            {
                if (!x.IsConfigured)
                {
                    x.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), sql =>
                    {
                        sql.MigrationsAssembly(migration);

                        sql.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                    });
                }
            });
        }
    }
}
