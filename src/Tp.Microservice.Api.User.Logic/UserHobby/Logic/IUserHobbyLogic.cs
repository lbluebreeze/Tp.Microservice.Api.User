using Tp.Microservice.Api.User.Entities.Abstractions;
using Tp.Microservice.Api.User.Logic.Abstractions;

namespace Tp.Microservice.Api.User.Logic.UserHobby.Logic
{
    /// <summary>
    /// Interfaz que expone los métodos de la capa lógica <see cref="UserHobbyLogic"/>
    /// </summary>
    public interface IUserHobbyLogic<TEntity> : ICoreLogic<TEntity> where TEntity : class, IEntityBase
    {
    }
}
