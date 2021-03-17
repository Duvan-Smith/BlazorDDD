using Blazor.Aplicacion.Core.FilmServices;
using Blazor.Aplicacion.Dto.FilmsDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.WebApi.Controllers.Films
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        private readonly ILogger<FilmController> _logger;
        private readonly IFilmService _filmService;
        public FilmController(ILogger<FilmController> logger, IFilmService filmService)
        {
            _logger = logger;
            _filmService = filmService;
        }
        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<FilmRequestDto>> GetAll() =>
            await _filmService.GetAllFilm().ConfigureAwait(false);
    }
}
