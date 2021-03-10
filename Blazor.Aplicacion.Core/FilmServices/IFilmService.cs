using Blazor.Aplicacion.Dto.FilmDto;
using System;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.FilmServices
{
    public interface IFilmService
    {
        public Task<Guid?> Agregar(FilmRequestDto request);
        public bool Eliminar(FilmRequestDto request);

        public FilmResponseDto GetUserByFilm(FilmRequestDto request);

        public bool ActualizarFilm(FilmRequestDto request);
    }
}
