using Microsoft.AspNetCore.Builder;
using System;
using System.Linq;

namespace Tp.Microservice.Api.User.Configuration.Startup.Cors
{
    /// <summary>
    /// Clase encargada de configurar los permisos de orígenes cruzados
    /// </summary>
    public static class CorsMiddleware
    {
        /// <summary>
        /// Método encargado de configurar los sitios permitidos para el origen cruzado desde variables de entorno
        /// </summary>
        public static void UseCustomCors(this IApplicationBuilder app)
        {
            var cors = Environment.GetEnvironmentVariable("CORS_ORIGINS")?.Split(",") ?? Array.Empty<string>();

            if (cors.Any())
            {
                app.UseCors(x => 
                    x.WithOrigins(cors)
                        .SetIsOriginAllowedToAllowWildcardSubdomains()
                        .AllowAnyHeader()
                        .WithMethods("GET", "POST", "PUT", "DELETE")
                        .AllowCredentials()
                );
            }
        }
    }
}
