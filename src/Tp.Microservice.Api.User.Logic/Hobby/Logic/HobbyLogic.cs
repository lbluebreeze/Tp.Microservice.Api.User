using Tp.Microservice.Api.User.EntityFramework;
using Tp.Microservice.Api.User.Logic.Abstractions;

namespace Tp.Microservice.Api.User.Logic.Hobby.Logic
{
    /// <summary>
    /// Clase encargada de administrar la entidad <see cref="Entities.Hobby"/>
    /// </summary>
    public class HobbyLogic : CoreLogic<Entities.Hobby>, IHobbyLogic<Entities.Hobby>
    {
        /// <summary>
        /// Crea una nueva instancia de <see cref="HobbyLogic"/>
        /// </summary>
        public HobbyLogic(MicroserviceContext context) : base(context)
        {
        }
    }
}
