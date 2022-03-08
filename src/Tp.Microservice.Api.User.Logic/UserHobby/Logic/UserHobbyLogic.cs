using Tp.Microservice.Api.User.EntityFramework;
using Tp.Microservice.Api.User.Logic.Abstractions;

namespace Tp.Microservice.Api.User.Logic.UserHobby.Logic
{
    /// <summary>
    /// Clase encargada de administrar la entidad <see cref="Entities.UserHobby"/>
    /// </summary>
    public class UserHobbyLogic : CoreLogic<Entities.UserHobby>, IUserHobbyLogic<Entities.UserHobby>
    {
        /// <summary>
        /// Crea una nueva instancia de <see cref="UserHobbyLogic"/>
        /// </summary>
        public UserHobbyLogic(MicroserviceContext context) : base(context)
        {
        }
    }
}
