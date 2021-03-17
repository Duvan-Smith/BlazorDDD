using Blazor.Aplicacion.Core.Users.FachadaUser;
using Blazor.Aplicacion.Dto.UsersDto.Registro;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.WebApi.Controllers.FachadaUser.Fachada
{
    [ApiController]
    [Route("[controller]")]
    public class FachadaUserController : ControllerBase
    {
        private readonly ILogger<FachadaUserController> _logger;
        private readonly IFachadaUserService _fachadaUserService;
        public FachadaUserController(ILogger<FachadaUserController> logger, IFachadaUserService fachadaUserService)
        {
            _logger = logger;
            _fachadaUserService = fachadaUserService;
        }
        [HttpPost(nameof(InsertUser))]
        public async Task<UserResponseDto> InsertUser(UserRequestDto userRequestDto) =>
            await _fachadaUserService.UserManagementInsert(userRequestDto).ConfigureAwait(false);
        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<UserRequestDto>> GetAll() =>
            await _fachadaUserService.UserManagementGetAll().ConfigureAwait(false);
    }
}
