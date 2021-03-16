using Blazor.Aplicacion.Dto.OperacionesDto.MultiplicacionDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Aplicacion.Core.Operaciones.Multiplicacion.Service
{
    public interface IMultiplicacionService
    {
        public double Multiplicar(MultiplicacionDto request);
        
      
    }
}
