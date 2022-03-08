using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tp.Microservice.Api.User.Abstractions;
using Tp.Microservice.Api.User.Data.Transfer.Objects;
using Tp.Microservice.Api.User.Logic.UserHobby.Logic;

namespace Tp.Microservice.Api.User.Controllers
{
    /// <summary>
    /// Controlador encargado de administrar la información de la entidad <see cref="Entities.UserHobby"/>
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserHobbyController : EntityBaseController<IUserHobbyLogic<Entities.UserHobby>, Entities.UserHobby, UserHobbyDto>
    {
        /// <summary>
        /// Crea una nueva instancia de <see cref="UserHobbyController"/>
        /// </summary>
        public UserHobbyController(IMapper mapper, IUserHobbyLogic<Entities.UserHobby> logic) : base(mapper, logic)
        {

        }
    }
}
