using System;
using System.ComponentModel.DataAnnotations;
using Tp.Microservice.Api.User.Data.Transfer.Objects.Abstractions;

namespace Tp.Microservice.Api.User.Data.Transfer.Objects
{
    /// <summary>
    /// Objeto de transferencia de datos con la información de la relación entre un usuario y un hobby. Ver <see cref="Entities.UserHobby"/>
    /// </summary>
    public class UserHobbyDto : IDtoBase
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
        [Range(0, int.MaxValue, ErrorMessage = "The {0} field is invalid")]
        public int IdUser { get; set; }
        /// <summary>
        /// Identificador del hobby
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "The {0} field is invalid")]
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
        /// Información del hobby asociado
        /// </summary>
        public HobbyDto Hobby { get; set; }
    }
}
