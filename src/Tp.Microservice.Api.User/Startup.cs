using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tp.Microservice.Api.User.Configuration.Startup.Cors;
using Tp.Microservice.Api.User.Configuration.Startup.DbContext;
using Tp.Microservice.Api.User.Configuration.Startup.Logic;
using Tp.Microservice.Api.User.Configuration.Startup.Swagger;
using Tp.Microservice.Api.User.EntityFramework;

namespace Tp.Microservice.Api.User
{
    /// <summary>
    /// Clase que administra los servicios de inicio del microservicio
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Contiene los datos de configuración del archivo appsetings.json
        /// </summary>
        private IConfiguration Configuration { get; set; }

        /// <summary>
        /// Crea una nueva instancia de <see cref="Startup"/>
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Método encargado de configurar los servicios del microservicio
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();

            services.AddAutoMapper(typeof(Startup));

            services.AddMicroserviceContext<MicroserviceContext>(this.Configuration);

            services.AddControllers()
                    .AddNewtonsoftJson();

            services.AddSwagger(this.Configuration);

            services.AddLogic();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseSwaggerMiddleware();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCustomCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
