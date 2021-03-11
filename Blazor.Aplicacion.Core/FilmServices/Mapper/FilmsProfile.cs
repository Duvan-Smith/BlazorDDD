using AutoMapper;
using Blazor.Aplicacion.Dto.FilmsDto;
using Blazor.Dominio.Films;

namespace Blazor.Aplicacion.Core.FilmServices.Mapper
{
    public class FilmsProfile : Profile
    {
        public FilmsProfile()
        {
            CreateMap<FilmEntity, FilmRequestDto>().ReverseMap();
        }
    }
}
