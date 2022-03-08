using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tp.Microservice.Api.User.Data.Transfer.Objects.Abstractions;

namespace Tp.Microservice.Api.User.Data.Transfer.Objects
{
    /// <summary>
    /// Objeto de transferencia de datos con la información del usuario. Ver <see cref="Entities.User"/>
    /// </summary>
    public class UserDto : IDtoBase
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
        [Required]
        [StringLength(128)]
        public string Username { get; set; }
        /// <summary>
        /// Contraseña de acceso para el usuario
        /// </summary>
        [Required]
        [StringLength(256)]
        public string Password { get; set; }
        /// <summary>
        /// Nombre completo del usuario
        /// </summary>
        [Required]
        [StringLength(256)]
        public string Fullname { get; set; }
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
        public List<UserHobbyDto> UserHobbies { get; set; } = new();
    }
}
