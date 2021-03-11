using System.ComponentModel.DataAnnotations;

namespace Blazor.Aplicacion.Dto.UsersDto.InicioSesion
{
    public class InicioSesionRequestDto
    {
        [Required]
        public string Contrasena { get; set; }
        [Required]
        [RegularExpression(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$")]
        public string Correo { get; set; }
    }
}
