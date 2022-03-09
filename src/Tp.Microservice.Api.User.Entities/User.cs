using System;
using System.Collections.Generic;
using Tp.Microservice.Api.User.Entities.Abstractions;

namespace Tp.Microservice.Api.User.Entities
{
    /// <summary>
    /// Representa la información de un usuario
    /// </summary>
    public class User : IEntityBase
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
        /// Nombre del usuario para el login
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Contraseña de acceso para el usuario
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Nombre completo del usuario
        /// </summary>
        public string Fullname { get; set; }
        /// <summary>
        /// Teléfono del usuario
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Estado del registro
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Lista de hobbies asociadas al usuario
        /// </summary>
        public List<UserHobby> UserHobbies { get; set; } = new();
    }
}
