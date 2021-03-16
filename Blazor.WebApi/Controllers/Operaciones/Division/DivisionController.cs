using Blazor.Aplicacion.Core.Operaciones.Division;
using Blazor.Aplicacion.Dto.OperacionesDto.DivisionDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Blazor.WebApi.Controllers.Operaciones.Division
{
    [ApiController]
    [Route("[controller]")]
    public class DivisionController : ControllerBase
    {
        private readonly ILogger<DivisionController> _logger;
        private readonly IDivisionService _divisionSvc;
        public DivisionController(ILogger<DivisionController> logger, IDivisionService divisionSvc)
        {
            _logger = logger;
            _divisionSvc = divisionSvc;
        }
        [HttpPost(nameof(Dividir))]
        public async Task<DivisionResponseDto> Dividir(DivisionRequestDto divisionRequestDto) =>
            await _divisionSvc.Dividir(divisionRequestDto).ConfigureAwait(false);
    }
}
