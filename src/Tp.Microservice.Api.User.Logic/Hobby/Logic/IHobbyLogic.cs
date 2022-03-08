using Tp.Microservice.Api.User.Entities.Abstractions;
using Tp.Microservice.Api.User.Logic.Abstractions;

namespace Tp.Microservice.Api.User.Logic.Hobby.Logic
{
    /// <summary>
    /// Interfaz que expone los métodos de la capa lógica <see cref="HobbyLogic"/>
    /// </summary>
    public interface IHobbyLogic<TEntity> : ICoreLogic<TEntity> where TEntity : class, IEntityBase
    {
    }
}
