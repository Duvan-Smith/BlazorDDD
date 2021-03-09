using Microsoft.AspNetCore.Mvc;

namespace BlazorCRUD.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        //private readonly ILogger<FilmController> _logger;
        //private readonly IFilmService _filmSvc;

        //public FilmController(ILogger<FilmController> logger, IFilmService filmSvc)
        //{
        //    _logger = logger;
        //    _filmSvc = filmSvc;
        //}

        //[HttpPost(nameof(Insert))]
        //public async Task<FilmResponseDto> Insert(FilmRequestDto request) =>
        //    await _restablecerContrasenaSvc.RestablecerContrasena(request).ConfigureAwait(false);
    }
}