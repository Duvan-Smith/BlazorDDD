using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Aplicacion.Dto.OperacionesDto.DivisionDtos
{
    public class DivisionRequestDto: DivisionDto
    {
        public double Divisor { get; set; }
        public double Dividendo { get; set; }
    }
}
