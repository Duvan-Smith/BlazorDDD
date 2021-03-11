using Blazor.Aplicacion.Dto.UsersDto.InicioSesion;
using Blazor.Aplicacion.Dto.UsersDto.Registro;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Users.FachadaUser
{
    public interface IFachadaUserService
    {
        public Task<UserResponseDto> UserManagement(UserRequestDto requestDto);
        public Task<InicioSesionResponseDto> UserLogin(InicioSesionRequestDto requestDto);

    }
}
