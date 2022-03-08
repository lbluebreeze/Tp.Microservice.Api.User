using System;

namespace Tp.Microservice.Api.User.Entities.Abstractions
{
    /// <summary>
    /// Interfaz con los atributos base para las entidades
    /// </summary>
    public interface IEntityBase
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
        /// Estado del registro
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime CreationDate { get; set; }
    }
}
