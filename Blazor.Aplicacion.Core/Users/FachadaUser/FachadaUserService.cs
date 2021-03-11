using Blazor.Aplicacion.Core.Users.InicioSesion;
using Blazor.Aplicacion.Core.Users.Registro;
using Blazor.Aplicacion.Dto.UsersDto.InicioSesion;
using Blazor.Aplicacion.Dto.UsersDto.Registro;
using System;
using System.Collections.Generic;
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
            return new UserResponseDto
            {
                Aceptado = await _userService.InsertUser(requestDto) != default ? true : false,
            };
        }
        public Task<UserResponseDto> UserManagementDelete(UserRequestDto requestDto)
        {
            return Task.FromResult(new UserResponseDto
            {
                Aceptado = _userService.DeleteUser(requestDto),
            });
        }

        public Task<UserResponseDto> UserManagementUpdate(UserRequestDto requestDto)
        {
            return Task.FromResult(new UserResponseDto
            {
                Aceptado = _userService.UpdateUser(requestDto),
            });
        }

        public Task<UserRequestDto> UserManagementGet(UserRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserRequestDto>> UserManagementGetAll(UserRequestDto requestDto)
        {
            throw new NotImplementedException();
        }
        public Task<InicioSesionResponseDto> UserLogin(InicioSesionRequestDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}
