using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tp.Microservice.Api.User.Entities.Abstractions;

namespace Tp.Microservice.Api.User.EntityFramework.EntityConfiguration.Extensions
{
    /// <summary>
    /// Clase que expone metodos de extensión para <see cref="EntityTypeBuilder"/>
    /// </summary>
    public static class EntityTypeBuilderExtension
    {
        /// <summary>
        /// Método encargado de configurar las propiedades base de las entidades basadas en <see cref="IEntityBase"/>
        /// </summary>
        public static void ConfigBase<TEntity>(this EntityTypeBuilder<TEntity> builder) where TEntity : class, IEntityBase
        {
            builder.Property(x => x.Id).HasColumnType("int").ValueGeneratedOnAdd();
            builder.Property(x => x.IdCreatorUser).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.CreationDate).IsRequired();
        }
    }
}
