using Blazor.Aplicacion.Dto.UsersDto.InicioSesion;
using Blazor.Aplicacion.Dto.UsersDto.Registro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Users.FachadaUser
{
    public interface IFachadaUserService
    {
        public Task<UserRequestDto> UserManagementGet(UserRequestDto requestDto);
        public Task<UserResponseDto> UserManagementInsert(UserRequestDto requestDto);
        public Task<UserResponseDto> UserManagementDelete(UserRequestDto requestDto);
        public Task<UserResponseDto> UserManagementUpdate(UserRequestDto requestDto);
        public Task<IEnumerable<UserRequestDto>> UserManagementGetAll();
        public Task<InicioSesionResponseDto> UserLogin(InicioSesionRequestDto requestDto);

    }
}
