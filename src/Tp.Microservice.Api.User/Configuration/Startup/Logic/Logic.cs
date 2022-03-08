using Microsoft.Extensions.DependencyInjection;
using Tp.Microservice.Api.User.Logic.Hobby.Logic;
using Tp.Microservice.Api.User.Logic.User.Logic;
using Tp.Microservice.Api.User.Logic.UserHobby.Logic;

namespace Tp.Microservice.Api.User.Configuration.Startup.Logic
{
    /// <summary>
    /// Clase encargada de configurar los servicios de capa lógica
    /// </summary>
    public static class Logic
    {
        /// <summary>
        /// Método encargado de configurar los servicios de capa lógica
        /// </summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors</param>
        public static void AddLogic(this IServiceCollection services)
        {
            services.AddTransient<IUserLogic<Entities.User>, UserLogic>();
            services.AddTransient<IHobbyLogic<Entities.Hobby>, HobbyLogic>();
            services.AddTransient<IUserHobbyLogic<Entities.UserHobby>, UserHobbyLogic>();
        }
    }
}
