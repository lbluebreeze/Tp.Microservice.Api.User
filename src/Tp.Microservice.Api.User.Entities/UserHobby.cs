using System;
using Tp.Microservice.Api.User.Entities.Abstractions;

namespace Tp.Microservice.Api.User.Entities
{
    /// <summary>
    /// Representa la relación entre un usuario y un hobby
    /// </summary>
    public class UserHobby : IEntityBase
    {
        /// <summary>
        /// Identificador del registro
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identificador del usuario creador del registro
        /// </summary>
        public int IdCreatorUser { get; set; }
        /// <summary>
        /// Identificador del usuario
        /// </summary>
        public int IdUser { get; set; }
        /// <summary>
        /// Identificador del hobby
        /// </summary>
        public int IdHobby { get; set; }
        /// <summary>
        /// Estado del registro
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Información del usuario asociado
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Información del hobby asociado
        /// </summary>
        public Hobby Hobby { get; set; }
    }
}
