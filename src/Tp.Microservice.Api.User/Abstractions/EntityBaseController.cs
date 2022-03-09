using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tp.Microservice.Api.User.Data.Transfer.Objects.Abstractions;
using Tp.Microservice.Api.User.Entities.Abstractions;
using Tp.Microservice.Api.User.Logic.Abstractions;

namespace Tp.Microservice.Api.User.Abstractions
{
    /// <summary>
    /// Controlador que contiene los métodos base para los controladores de las entidades
    /// </summary>
    public class EntityBaseController<TLogic, TEntity, TDto> : ControllerBase where TLogic : ICoreLogic<TEntity> where TEntity : class, IEntityBase where TDto : class, IDtoBase
    {
        /// <summary>
        /// Api que permite mapear la información entre los diferentes objetos del sistema
        /// </summary>
        protected readonly IMapper mapper;
        /// <summary>
        /// Clase encargada de administrar la entidad <see cref="Entities.User"/>
        /// </summary>
        private readonly TLogic logic;

        /// <summary>
        /// Crea una nueva instancia de <see cref="EntityBaseController{TLogic, TEntity, TDto}"/>
        /// </summary>
        public EntityBaseController(IMapper mapper, TLogic logic)
        {
            this.mapper = mapper;
            this.logic = logic;
        }

        /// <summary>
        /// Servicio encargado de obtener todos los registros
        /// </summary>
        /// <response code="200">Retorna una lista de registros</response>
        /// <response code="500">Internal Server error</response>
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public virtual async Task<IActionResult> All()
        {
            var entities = await this.logic.AllAsync<TEntity>();

            var result = this.mapper.Map<List<TDto>>(entities);

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
        public virtual async Task<IActionResult> Get(int id)
        {
            var entity = await this.logic.GetAsync<TEntity>(id);

            var result = this.mapper.Map<TDto>(entity);

            return Ok(result);
        }

        /// <summary>
        /// Servicio encargado de crear un registro
        /// </summary>
        /// <response code="200">Retorna el identificador del registro creado</response>
        /// <response code="500">Internal Server error</response>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public virtual async Task<IActionResult> Post([FromBody] TDto dto)
        {
            var entity = this.mapper.Map<TEntity>(dto);

            var result = await this.logic.CreateAsync(entity);

            return Ok(result);
        }

        /// <summary>
        /// Servicio encargado de actualizar un registro
        /// </summary>
        /// <response code="200">Retorna un booleano con el resultado de la operación</response>
        /// <response code="500">Internal Server error</response>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public virtual async Task<IActionResult> Put([FromBody] TDto dto)
        {
            var entity = this.mapper.Map<TEntity>(dto);

            var result = await this.logic.UpdateAsync(entity);

            return Ok(result);
        }

        /// <summary>
        /// Servicio encargado de cambiar el estado de un registro
        /// </summary>
        /// <response code="200">Retorna un booleano con el resultado de la operación</response>
        /// <response code="500">Internal Server error</response>
        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public virtual async Task<IActionResult> ChangeState(int id, bool state)
        {
            var result = await this.logic.ChangeStateAsync<Entities.User>(id, state);

            return Ok(result);
        }

        /// <summary>
        /// Servicio encargado de eliminar un registro
        /// </summary>
        /// <response code="200">Retorna un booleano con el resultado de la operación</response>
        /// <response code="500">Internal Server error</response>
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var result = await this.logic.DeleteAsync<Entities.User>(id);

            return Ok(result);
        }
    }
}
