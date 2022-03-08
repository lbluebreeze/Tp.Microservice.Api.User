using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tp.Microservice.Api.User.Abstractions;
using Tp.Microservice.Api.User.Data.Transfer.Objects;
using Tp.Microservice.Api.User.Logic.User.Logic;

namespace Tp.Microservice.Api.User.Controllers
{
    /// <summary>
    /// Controlador encargado de administrar la información de la entidad <see cref="Entities.User"/>
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : EntityBaseController<IUserLogic<Entities.User>, Entities.User, UserDto>
    {
        /// <summary>
        /// Clase encargada de administrar la entidad <see cref="Entities.User"/>
        /// </summary>
        private readonly IUserLogic<Entities.User> logic;

        /// <summary>
        /// Crea una nueva instancia de <see cref="UserController"/>
        /// </summary>
        public UserController(IMapper mapper, IUserLogic<Entities.User> logic) : base(mapper, logic)
        {
            this.logic = logic;
        }

        /// <summary>
        /// Servicio encargado de obtener todos los registros
        /// </summary>
        /// <response code="200">Retorna el registro encontrado</response>
        /// <response code="500">Internal Server error</response>
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public override async Task<IActionResult> All()
        {
            var entities = await this.logic.AllAsync();

            var result = this.mapper.Map<List<UserDto>>(entities);

            return Ok(result);
        }

        /// <summary>
        /// Servicio encargado de obtener un registro por su llave primaria
        /// </summary>
        /// <response code="200">Retorna el registro encontrado</response>
        /// <response code="500">Internal Server error</response>
        [HttpGet]
        [Route("[action]/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public override async Task<IActionResult> Get(int id)
        {
            var entity = await this.logic.GetAsync(id);

            var result = this.mapper.Map<UserDto>(entity);

            return Ok(result);
        }


        /// <summary>
        /// Servicio encargado de validar el login de un usuario
        /// </summary>
        /// <response code="200">Retorna la información del usuario logueado</response>
        /// <response code="500">Internal Server error</response>
        [HttpGet]
        [Route("[action]/{username}/{password}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Login(string username, string password)
        {
            var entity = await this.logic.LoginAsync(username, password);

            var result = this.mapper.Map<UserDto>(entity);

            return Ok(result);
        }
    }
}
