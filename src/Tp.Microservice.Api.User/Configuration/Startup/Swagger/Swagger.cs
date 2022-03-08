using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;

namespace Tp.Microservice.Api.User.Configuration.Startup.Swagger
{
    /// <summary>
    /// Clase encargada de configurar el componente Swagger
    /// </summary>
    public static class Swagger
    {
        /// <summary>
        /// Versión de la aplicación
        /// </summary>
        private const string Version = "v1";
        /// <summary>
        /// Título de la aplicación
        /// </summary>
        private const string Title = "Tp.Microservice.Api.User";
        /// <summary>
        /// Descripción de la aplicación
        /// </summary>
        private const string Description = "Microservicio encargado de la administración de usuarios y sus hobbies";

        /// <summary>
        /// Método encargado de configurar la aplicación Swagger
        /// </summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors</param>
        /// <param name="configuration">Represents a set of key/value application configuration properties</param>
        public static void AddSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc(Version, new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = Title,
                    Version = Version,
                    Description = Description
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                x.IncludeXmlComments(xmlPath);
            });
        }

        /// <summary>
        /// Metodo encargado de configurar el middleware de Swagger
        /// </summary>
        /// <param name="app">Defines a class that provides the mechanisms to configure an application's request</param>
        public static void UseSwaggerMiddleware(this IApplicationBuilder app)
        {
            app.UseSwagger()
                .UseSwaggerUI(x =>
                {
                    x.SwaggerEndpoint($"/swagger/v1/swagger.json", Title);
                });
        }
    }
}
