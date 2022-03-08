using AutoMapper;
using Tp.Microservice.Api.User.Data.Transfer.Objects;

namespace Tp.Microservice.Api.User.Configuration.Startup.AutoMapper
{
    /// <summary>
    /// Clase encargada de configurar el mapeo de entidades
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// Crea una nueva instancia de <see cref="AutoMapperProfile"/>
        /// </summary>
        public AutoMapperProfile()
        {
            CreateMap<Entities.User, UserDto>().ReverseMap();
            CreateMap<Entities.Hobby, HobbyDto>().ReverseMap();
            CreateMap<Entities.UserHobby, UserHobbyDto>().ReverseMap();
        }
    }
}
