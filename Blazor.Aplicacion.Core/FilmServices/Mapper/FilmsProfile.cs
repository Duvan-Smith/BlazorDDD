using AutoMapper;
using Blazor.Aplicacion.Dto.FilmDto;
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
