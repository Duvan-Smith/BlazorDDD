using AutoMapper;
using Blazor.Aplicacion.Dto.UsersDto.InicioSesion;
using Blazor.Dominio.Users;

namespace Blazor.Aplicacion.Core.Users.InicioSesion.Mapper
{
    class InicioSesionProfile : Profile
    {
        public InicioSesionProfile()
        {
            CreateMap<UserEntity, InicioSesionRequestDto>().ReverseMap();
        }
    }
}
