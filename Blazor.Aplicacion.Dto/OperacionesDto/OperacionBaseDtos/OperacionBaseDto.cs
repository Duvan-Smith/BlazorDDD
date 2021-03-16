using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blazor.Aplicacion.Dto.OperacionesDto.OperacionBaseDtos
{
    public class OperacionBaseDto
    {
        [Key]
        public int IdOperacion { get; set; }
        public double Resultado { get; set; }
    }
}
