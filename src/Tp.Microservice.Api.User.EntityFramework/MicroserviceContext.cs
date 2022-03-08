using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Tp.Microservice.Api.User.EntityFramework
{
    /// <summary>
    /// Contexto de base de datos para el microservicio
    /// </summary>
    public class MicroserviceContext : DbContext
    {
        /// <summary>
        /// Crea una nueva instancia de <see cref="MicroserviceContext"/>
        /// </summary>
        public MicroserviceContext(DbContextOptions<MicroserviceContext> options) : base(options) { }

        /// <summary>
        /// Método encargado de configurar e inicializar la base de datos del microservicio
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(MicroserviceContext)));
        }

        /// <summary>
        /// DbSet of Users
        /// </summary>
        public DbSet<Entities.User> User { get; set; }

        /// <summary>
        /// DbSet of Hobbies
        /// </summary>
        public DbSet<Entities.Hobby> Hobby { get; set; }

        /// <summary>
        /// DbSet of UserHobbies
        /// </summary>
        public DbSet<Entities.UserHobby> UserHobby { get; set; }
    }
}
