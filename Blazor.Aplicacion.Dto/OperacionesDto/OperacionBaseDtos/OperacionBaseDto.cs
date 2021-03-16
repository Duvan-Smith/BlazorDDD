using Blazor.Aplicacion.Dto.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Aplicacion.Dto.OperacionesDto.OperacionBaseDtos
{
    public class OperacionBaseDto : DataTransferObject
    {
        [Key]
        public Guid IdOperacion { get; set; }
        [Required]
        public double Resultado { get; set; }
    }
}
