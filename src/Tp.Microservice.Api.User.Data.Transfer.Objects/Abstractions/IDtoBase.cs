using System;

namespace Tp.Microservice.Api.User.Data.Transfer.Objects.Abstractions
{
    /// <summary>
    /// Interfaz con las propiedades base para los objetos de transferencia de datos (DTO)
    /// </summary>
    public interface IDtoBase
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
