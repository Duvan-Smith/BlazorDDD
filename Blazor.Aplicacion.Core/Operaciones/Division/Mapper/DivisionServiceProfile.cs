using AutoMapper;
using Blazor.Aplicacion.Dto.OperacionesDto.DivisionDtos;
using Blazor.Dominio.Operaciones.Division;

namespace Blazor.Aplicacion.Core.Operaciones.Division.Mapper
{
    class DivisionServiceProfile : Profile
    {
        public DivisionServiceProfile()
        {
            CreateMap<DivisionEntity, DivisionDto>().ReverseMap();
            CreateMap<DivisionEntity, DivisionRequestDto>().ReverseMap();
        }
    }
}
