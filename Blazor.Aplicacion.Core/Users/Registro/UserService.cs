using Blazor.Aplicacion.Core.FilmServices;
using Blazor.Aplicacion.Dto.FilmsDto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Users.Registro
{
    public class UserService : IFilmService
    {
        public bool ActualizarFilm(FilmRequestDto request)
        {
            throw new NotImplementedException();
        }
        public Task<Guid?> Agregar(FilmRequestDto request)
        {
            throw new NotImplementedException();
        }
        public bool Eliminar(FilmRequestDto request)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<FilmRequestDto> GetAllFilm()
        {
            throw new NotImplementedException();
        }
        public FilmRequestDto GetFilmByFilm(Guid request)
        {
            throw new NotImplementedException();
        }
    }
}
