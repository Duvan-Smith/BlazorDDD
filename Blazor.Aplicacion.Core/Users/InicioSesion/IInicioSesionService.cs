using Blazor.Aplicacion.Dto.UsersDto.InicioSesion;

namespace Blazor.Aplicacion.Core.Users.InicioSesion
{
    public interface IInicioSesionService
    {
        public InicioSesionResponseDto Autenticar(InicioSesionRequestDto request);
    }
}
