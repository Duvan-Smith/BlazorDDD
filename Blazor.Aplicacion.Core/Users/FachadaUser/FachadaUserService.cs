using Blazor.Aplicacion.Dto.UsersDto.InicioSesion;
using Blazor.Aplicacion.Dto.UsersDto.Registro;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Users.FachadaUser
{
    public class FachadaUserService : IFachadaUserService
    {
        public Task<InicioSesionResponseDto> UserLogin(InicioSesionRequestDto requestDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserResponseDto> UserManagement(UserRequestDto requestDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
