using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Tp.Microservice.Api.User.Entities.Abstractions;
using Tp.Microservice.Api.User.EntityFramework;

namespace Tp.Microservice.Api.User.Logic.Abstractions
{
    /// <summary>
    /// Clase que implementa los métodos base de administración de entidades
    /// </summary>
    public class CoreLogic<TEntity> : ICoreLogic<TEntity> where TEntity : class, IEntityBase
    {
        /// <summary>
        /// Contexto de base de datos para el microservicio
        /// </summary>
        private readonly MicroserviceContext context;

        /// <summary>
        /// Crea una nueva instancia de <see cref="CoreLogic"/>
        /// </summary>
        public CoreLogic(MicroserviceContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Método encargado de obtener todos los registros
        /// </summary>
        public async Task<List<TEntity>> AllAsync<TEntity>() where TEntity : class, IEntityBase
        {
            return await this.context.Set<TEntity>().ToListAsync();
        }

        /// <summary>
        /// Método encargado de obtener un registro por su llave primaria
        /// </summary>
        /// <param name="id">Identificador del registro</param>
        public async Task<TEntity> GetAsync<TEntity>(int id) where TEntity : class, IEntityBase
        {
            return await this.context.Set<TEntity>().FindAsync(id);
        }

        /// <summary>
        /// Método encargado de crear una entidad
        /// </summary>
        /// <param name="entity">Entidad a crear</param>
        /// <param name="cancellationToken">Token de cancelación para la operación</param>
        /// <returns>Un int con la identificador del registro creado</returns>
        public async Task<int> CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            entity.CreationDate = DateTime.Now;

            this.context.Add(entity);

            await this.context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }

        /// <summary>
        /// Método encargado de actualizar una entidad
        /// </summary>
        /// <param name="entity">Entidad a actualizar</param>
        /// <param name="cancellationToken">Token de cancelación para la operación</param>
        /// <returns>Un bool con el resultado de la actualización</returns>
        public async Task<bool> UpdateAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default) where TEntity : class, IEntityBase
        {
            this.context.Set<TEntity>().Update(entity);

            return await this.context.SaveChangesAsync(cancellationToken) > 0;
        }

        /// <summary>
        /// Método encargado de cambiar el estado de un registro
        /// </summary>
        /// <param name="id">Identificador del registro</param>
        /// <param name="state">Estado a asignar al registro</param>
        /// <param name="cancellationToken">Token de cancelación para la operación</param>
        /// <returns>Un bool con el resultado de la actualización</returns>
        public async Task<bool> ChangeStateAsync<TEntity>(int id, bool state, CancellationToken cancellationToken = default) where TEntity : class, IEntityBase
        {
            var entity = this.context.Set<TEntity>().FirstOrDefault(x => x.Id.Equals(id));

            if (entity == null)
            {
                return false;
            }

            entity.State = state;

            return await this.context.SaveChangesAsync(cancellationToken) > 0;
        }

        /// <summary>
        /// Método encargado de eliminar un registro
        /// </summary>
        /// <param name="id">Identificador del registro</param>
        /// <param name="cancellationToken">Token de cancelación para la operación</param>
        /// <returns>Un bool con el resultado de la eliminación</returns>
        public async Task<bool> DeleteAsync<TEntity>(int id, CancellationToken cancellationToken = default) where TEntity : class, IEntityBase
        {
            var entity = this.context.Set<TEntity>().FirstOrDefault(x => x.Id.Equals(id));

            if (entity == null)
            {
                return false;
            }

            this.context.Set<TEntity>().Remove(entity);

            return await this.context.SaveChangesAsync(cancellationToken) > 0;
        }
    }
}
