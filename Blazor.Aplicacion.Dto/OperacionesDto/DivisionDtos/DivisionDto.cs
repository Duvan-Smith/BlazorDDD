using Blazor.Aplicacion.Dto.OperacionesDto.OperacionBaseDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blazor.Aplicacion.Dto.OperacionesDto.DivisionDtos
{
    public class DivisionDto: OperacionBaseDto
    {
        public double Divisor { get; set; }
        public double Dividendo { get; set; }
    }
}