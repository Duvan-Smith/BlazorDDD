using Blazor.Aplicacion.Core.Users.InicioSesion;
using Blazor.Aplicacion.Core.Users.Registro;
using Blazor.Aplicacion.Dto.UsersDto.InicioSesion;
using Blazor.Aplicacion.Dto.UsersDto.Registro;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Users.FachadaUser
{
    public class FachadaUserService : IFachadaUserService
    {
        private readonly IUserService _userService;
        private readonly IInicioSesionService _inicioSesionService;

        public FachadaUserService(IUserService userService, IInicioSesionService inicioSesionService)
        {
            _userService = userService;
            _inicioSesionService = inicioSesionService;
        }

        public async Task<UserResponseDto> UserManagementInsert(UserRequestDto requestDto)
        {
            var result = await _userService.InsertUser(requestDto) != default ? true : false;
            return new UserResponseDto
            {
                Aceptado = result,
                StatusCode = result ? HttpStatusCode.OK : HttpStatusCode.Unauthorized,
                StatusDescription = result ? "Insert" : "No insert"
            };
        }
        public Task<UserResponseDto> UserManagementDelete(UserRequestDto requestDto)
        {
            var result = _userService.DeleteUser(requestDto);
            return Task.FromResult(new UserResponseDto
            {
                Aceptado = result,
                StatusCode = result ? HttpStatusCode.OK : HttpStatusCode.Unauthorized,
                StatusDescription = result ? "Delete" : "No delete"
            });
        }
        public Task<UserResponseDto> UserManagementUpdate(UserRequestDto requestDto)
        {
            var result = _userService.UpdateUser(requestDto);
            return Task.FromResult(new UserResponseDto
            {
                Aceptado = result,
                StatusCode = result ? HttpStatusCode.OK : HttpStatusCode.Unauthorized,
                StatusDescription = result ? "Updtae" : "No update"
            });
        }
        public Task<UserRequestDto> UserManagementGet(UserRequestDto requestDto)
        {
            return Task.FromResult(_userService.GetUser(requestDto));
        }
        public Task<IEnumerable<UserRequestDto>> UserManagementGetAll()
        {
            return Task.FromResult(_userService.GetAllUser());
        }
        public Task<InicioSesionResponseDto> UserLogin(InicioSesionRequestDto requestDto)
        {
            return Task.FromResult(_inicioSesionService.Autenticar(requestDto));
        }
    }
}
