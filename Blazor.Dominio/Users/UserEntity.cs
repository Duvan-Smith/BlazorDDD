using Blazor.Dominio.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Dominio.Users
{
    public class UserEntity : EntidadBase
    {
        [Key]
        public Guid UsuarioId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Contrasena { get; set; }

        [Required]
        public DateTimeOffset FechaRegistro { get; set; }

        [Required]
        //[RegularExpression(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$")]
        public string Correo { get; set; }

        [Required]
        public int Rol { get; set; }
    }
}
