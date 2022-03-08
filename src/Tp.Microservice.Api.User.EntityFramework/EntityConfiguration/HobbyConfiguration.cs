using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tp.Microservice.Api.User.EntityFramework.EntityConfiguration.Extensions;

namespace Tp.Microservice.Api.User.EntityFramework.EntityConfiguration
{
    /// <summary>
    /// Clase encargada de configurar la entidad <see cref="Entities.Hobby"/>
    /// </summary>
    public class HobbyConfiguration : IEntityTypeConfiguration<Entities.Hobby>
    {
        /// <summary>
        /// Método encargado de configurar la entidad <see cref="Entities.Hobby"/>
        /// </summary>
        public void Configure(EntityTypeBuilder<Entities.Hobby> builder)
        {
            builder.ToTable("Hobby");
            builder.Property(x => x.Name).HasColumnType("varchar(256)").IsRequired();
            builder.Property(x => x.Description).HasColumnType("varchar(512)");

            builder.ConfigBase();
        }
    }
}
