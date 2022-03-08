using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tp.Microservice.Api.User.EntityFramework;
using Tp.Microservice.Api.User.Logic.Abstractions;

namespace Tp.Microservice.Api.User.Logic.User.Logic
{
    /// <summary>
    /// Clase encargada de administrar la entidad <see cref="Entities.User"/>
    /// </summary>
    public class UserLogic : CoreLogic<Entities.User>, IUserLogic<Entities.User>
    {
        /// <summary>
        /// Contexto de base de datos para el microservicio
        /// </summary>
        private readonly MicroserviceContext context;

        /// <summary>
        /// Crea una nueva instancia de <see cref="UserLogic"/>
        /// </summary>
        public UserLogic(MicroserviceContext context) : base(context)
        {
            this.context = context;
        }

        /// <summary>
        /// Método encargado de obtener todos los registros con su información relacionada
        /// </summary>
        public async Task<List<Entities.User>> AllAsync()
        {
            return await this.context.Set<Entities.User>().Include(x => x.UserHobbies).ThenInclude(x => x.Hobby).ToListAsync();
        }

        /// <summary>
        /// Método encargado de obtener un registro de usuario con su información relacionada
        /// </summary>
        /// <param name="id">Identificador del registro</param>
        public async Task<Entities.User> GetAsync(int id)
        {
            return await this.context.Set<Entities.User>().Where(x => x.Id.Equals(id)).Include(x => x.UserHobbies).ThenInclude(x => x.Hobby).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Método encargado validar las credenciales de un usuario
        /// </summary>
        /// <param name="username">Login del usuario</param>
        /// <param name="password">Contraseña del usuario</param>
        public async Task<Entities.User> LoginAsync(string username, string password)
        {
            var result = await this.context.Set<Entities.User>().Where(x => x.Username.Equals(username) && x.Password.Equals(password)).FirstOrDefaultAsync();

            return result;
        }
    }
}
