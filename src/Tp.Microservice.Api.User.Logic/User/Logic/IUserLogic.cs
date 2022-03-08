using System.Collections.Generic;
using System.Threading.Tasks;
using Tp.Microservice.Api.User.Entities.Abstractions;
using Tp.Microservice.Api.User.Logic.Abstractions;

namespace Tp.Microservice.Api.User.Logic.User.Logic
{
    /// <summary>
    /// Interfaz que expone los métodos de la capa lógica <see cref="UserLogic"/>
    /// </summary>
    public interface IUserLogic<TEntity> : ICoreLogic<TEntity> where TEntity : class, IEntityBase
    {
        /// <summary>
        /// Método encargado de obtener todos los registros con su información relacionada
        /// </summary>
        Task<List<Entities.User>> AllAsync();
        /// <summary>
        /// Método encargado de obtener un registro por su llave primaria
        /// </summary>
        /// <param name="id">Identificador del registro</param>
        Task<Entities.User> GetAsync(int id);
        /// <summary>
        /// Método encargado validar las credenciales de un usuario
        /// </summary>
        /// <param name="username">Login del usuario</param>
        /// <param name="password">Contraseña del usuario</param>
        Task<Entities.User> LoginAsync(string username, string password);
    }
}
