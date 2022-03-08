using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tp.Microservice.Api.User.EntityFramework.EntityConfiguration.Extensions;

namespace Tp.Microservice.Api.User.EntityFramework.EntityConfiguration
{
    /// <summary>
    /// Clase encargada de configurar la entidad <see cref="Entities.UserHobby"/>
    /// </summary>
    public class UserHobbyConfiguration : IEntityTypeConfiguration<Entities.UserHobby>
    {
        /// <summary>
        /// Método encargado de configurar la entidad <see cref="Entities.UserHobby"/>
        /// </summary>
        public void Configure(EntityTypeBuilder<Entities.UserHobby> builder)
        {
            builder.ToTable("Usuario_Hobby");
            builder.Property(x => x.IdUser).HasColumnType("int").IsRequired();
            builder.Property(x => x.IdHobby).HasColumnType("int").IsRequired();

            builder.ConfigBase();

            builder.HasOne(x => x.User).WithMany(x => x.UserHobbies).HasForeignKey(x => x.IdUser).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Hobby).WithMany(x => x.UserHobbies).HasForeignKey(x => x.IdHobby).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
