using Blazor.Aplicacion.Dto.FilmDto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.FilmServices
{
    public interface IFilmService
    {
        public Task<Guid?> Agregar(FilmRequestDto request);
        public bool Eliminar(FilmRequestDto request);

        public FilmRequestDto GetFilmByFilm(Guid request);
        public IEnumerable<FilmRequestDto> GetAllFilm();

        public bool ActualizarFilm(FilmRequestDto request);
    }
}
