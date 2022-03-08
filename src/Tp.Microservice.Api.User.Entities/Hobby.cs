using System;
using System.Collections.Generic;
using Tp.Microservice.Api.User.Entities.Abstractions;

namespace Tp.Microservice.Api.User.Entities
{
    /// <summary>
    /// Representa la información de un hobby
    /// </summary>
    public class Hobby : IEntityBase
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
        public string Name { get; set; }
        /// <summary>
        /// Descripción del hobby
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Estado del registro
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Lista de usuarios asociados al hobby
        /// </summary>
        public List<UserHobby> UserHobbies { get; set; } = new();
    }
}
