using AutoMapper;
using Blazor.Aplicacion.Core.FilmServices.Excepciones;
using Blazor.Aplicacion.Dto.FilmsDto;
using Blazor.Dominio.Films;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.FilmServices
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepositorio _repoFilm;
        private readonly IMapper _mapper;

        public FilmService(IFilmRepositorio repoFilm, IMapper mapper)
        {
            _mapper = mapper;
            _repoFilm = repoFilm;
        }
        public async Task<Guid?> Agregar(FilmRequestDto request)
        {
            ValidarCamposRequeridos(request);

            var usernameExist = _repoFilm
                .SearchMatching<FilmEntity>(x => x.Id == request.Id)
                .Any();

            if (usernameExist)
                throw new UsernameAlreadyExistException(request.Director);

            var response = await _repoFilm.Insert(_mapper.Map<FilmEntity>(request)).ConfigureAwait(false);

            return response.Id;
        }

        private static void ValidarCamposRequeridos(FilmRequestDto request)
        {
            if (string.IsNullOrEmpty(request?.Director))
                throw new UsernameNotDefinedException();
        }

        public Task<FilmRequestDto> GetFilmByFilm(Guid request)
        {
            var user = _repoFilm
                .SearchMatching<FilmEntity>(x => x.Id == request);

            return Task.FromResult(_mapper.Map<FilmRequestDto>(user.FirstOrDefault()));
        }

        public Task<bool> ActualizarFilm(FilmRequestDto film)
        {
            var entity = _repoFilm.SearchMatchingOneResult<FilmEntity>(x => x.Id == film.Id);
            entity.Title = film.Title;
            entity.Director = film.Director;
            entity.ReleaseDate = film.ReleaseDate;

            return Task.FromResult(_repoFilm.Update(entity));
        }

        public Task<bool> Eliminar(FilmRequestDto request)
        {
            var entity = _mapper.Map<FilmEntity>(request);
            return Task.FromResult(_repoFilm.Delete(entity));
        }

        public Task<IEnumerable<FilmRequestDto>> GetAllFilm()
        {
            var user = _repoFilm
                .GetAll<FilmEntity>();

            return Task.FromResult(_mapper.Map<IEnumerable<FilmRequestDto>>(user));
        }
    }
}
