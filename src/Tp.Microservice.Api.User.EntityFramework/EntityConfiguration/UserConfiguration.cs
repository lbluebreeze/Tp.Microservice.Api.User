using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tp.Microservice.Api.User.EntityFramework.EntityConfiguration.Extensions;

namespace Tp.Microservice.Api.User.EntityFramework.EntityConfiguration
{
    /// <summary>
    /// Clase encargada de configurar la entidad <see cref="Entities.User"/>
    /// </summary>
    public class UserConfiguration : IEntityTypeConfiguration<Entities.User>
    {
        /// <summary>
        /// Método encargado de configurar la entidad <see cref="Entities.User"/>
        /// </summary>
        public void Configure(EntityTypeBuilder<Entities.User> builder)
        {
            builder.ToTable("Usuario");
            builder.Property(x => x.Username).HasColumnType("varchar(128)").IsRequired();
            builder.Property(x => x.Password).HasColumnType("varchar(256)").IsRequired();
            builder.Property(x => x.Fullname).HasColumnType("varchar(256)").IsRequired();
            builder.Property(x => x.Phone).HasColumnType("varchar(32)");

            builder.ConfigBase();

            builder.HasIndex(x => x.Username).IsUnique();
        }
    }
}
