using AutoMapper;
using Blazor.Aplicacion.Dto.UsersDto.Registro;
using Blazor.Dominio.Users;

namespace Blazor.Aplicacion.Core.Users.Registro.Mapper
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<UserEntity, UserRequestDto>().ReverseMap();
        }
    }
}