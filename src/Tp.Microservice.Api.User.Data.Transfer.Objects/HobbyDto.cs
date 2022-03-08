using System;
using System.ComponentModel.DataAnnotations;
using Tp.Microservice.Api.User.Data.Transfer.Objects.Abstractions;

namespace Tp.Microservice.Api.User.Data.Transfer.Objects
{
    /// <summary>
    /// Objeto de transferencia de datos con la información de un hobby. Ver <see cref="Entities.Hobby"/>
    /// </summary>
    public class HobbyDto : IDtoBase
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
        /// Nombre del hobby
        /// </summary>
        [Required]
        [StringLength(256)]
        public string Name { get; set; }
        /// <summary>
        /// Descripción del hobby
        /// </summary>
        [Required]
        [StringLength(512)]
        public string Description { get; set; }
        /// <summary>
        /// Estado del registro
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime CreationDate { get; set; }
    }
}
