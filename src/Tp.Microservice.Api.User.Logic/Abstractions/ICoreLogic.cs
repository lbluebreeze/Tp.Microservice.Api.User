using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tp.Microservice.Api.User.Entities.Abstractions;

namespace Tp.Microservice.Api.User.Logic.Abstractions
{
    /// <summary>
    /// Interfaz que expone los métodos base para la capa lógica de las entidades
    /// </summary>
    public interface ICoreLogic<TEntity> where TEntity : class, IEntityBase
    {
        /// <summary>
        /// Método encargado de obtener todos los registros
        /// </summary>
        Task<List<TEntity>> AllAsync<TEntity>() where TEntity : class, IEntityBase;
        /// <summary>
        /// Método encargado de obtener un registro por su llave primaria
        /// </summary>
        /// <param name="id">Identificador del registro</param>
        Task<TEntity> GetAsync<TEntity>(int id) where TEntity : class, IEntityBase;
        /// <summary>
        /// Método encargado de crear una entidad
        /// </summary>
        /// <param name="entity">Entidad a crear</param>
        /// <param name="cancellationToken">Token de cancelación para la operación</param>
        /// <returns>Un int con la identificador del registro creado</returns>
        Task<int> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);
        /// <summary>
        /// Método encargado de actualizar una entidad
        /// </summary>
        /// <param name="entity">Entidad a actualizar</param>
        /// <param name="cancellationToken">Token de cancelación para la operación</param>
        /// <returns>Un bool con el resultado de la actualización</returns>
        Task<bool> UpdateAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default) where TEntity : class, IEntityBase;
        /// <summary>
        /// Método encargado de cambiar el estado de un registro
        /// </summary>
        /// <param name="id">Identificador del registro</param>
        /// <param name="state">Estado a asignar al registro</param>
        /// <param name="cancellationToken">Token de cancelación para la operación</param>
        /// <returns>Un bool con el resultado de la actualización</returns>
        Task<bool> ChangeStateAsync<TEntity>(int id, bool state, CancellationToken cancellationToken = default) where TEntity : class, IEntityBase;
        /// <summary>
        /// Método encargado de eliminar un registro
        /// </summary>
        /// <param name="id">Identificador del registro</param>
        /// <param name="cancellationToken">Token de cancelación para la operación</param>
        /// <returns>Un bool con el resultado de la eliminación</returns>
        Task<bool> DeleteAsync<TEntity>(int id, CancellationToken cancellationToken = default) where TEntity : class, IEntityBase;
    }
}
