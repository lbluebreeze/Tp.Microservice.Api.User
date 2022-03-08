using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tp.Microservice.Api.User.Abstractions;
using Tp.Microservice.Api.User.Data.Transfer.Objects;
using Tp.Microservice.Api.User.Logic.Hobby.Logic;

namespace Tp.Microservice.Api.User.Controllers
{
    /// <summary>
    /// Controlador encargado de administrar la información de la entidad <see cref="Entities.Hobby"/>
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HobbyController : EntityBaseController<IHobbyLogic<Entities.Hobby>, Entities.Hobby, HobbyDto>
    {
        /// <summary>
        /// Crea una nueva instancia de <see cref="HobbyController"/>
        /// </summary>
        public HobbyController(IMapper mapper, IHobbyLogic<Entities.Hobby> logic) : base(mapper, logic)
        {

        }
    }
}
