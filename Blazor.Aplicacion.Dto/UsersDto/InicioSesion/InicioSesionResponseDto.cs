using Blazor.Aplicacion.Dto.Base;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Aplicacion.Dto.UsersDto.InicioSesion
{
    public class InicioSesionResponseDto : DataTransferObject
    {
        [Required]
        public bool Autenticado { get; set; }
    }
}
