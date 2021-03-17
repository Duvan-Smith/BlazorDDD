using Blazor.Aplicacion.Dto.FilmsDto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.FilmServices
{
    public interface IFilmService
    {
        public Task<Guid?> Agregar(FilmRequestDto request);
        public Task<bool> Eliminar(FilmRequestDto request);

        public Task<FilmRequestDto> GetFilmByFilm(Guid request);
        public Task<IEnumerable<FilmRequestDto>> GetAllFilm();

        public Task<bool> ActualizarFilm(FilmRequestDto request);
    }
}
