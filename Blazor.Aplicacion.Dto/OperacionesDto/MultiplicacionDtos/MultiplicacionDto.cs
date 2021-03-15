using Blazor.Aplicacion.Dto.OperacionesDto.OperacionBaseDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Aplicacion.Dto.OperacionesDto.MultiplicacionDtos
{
    public class MultiplicacionDto : OperacionBaseDto
    {
        public double Factor1 { get; set; }
        public double Factor2 { get; set; }
    }
}
