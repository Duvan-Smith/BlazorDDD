using Blazor.Aplicacion.Dto.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Aplicacion.Dto.OperacionesDto.OperacionBaseDtos
{
    public class OperacionBaseDto : DataTransferObject
    {
        public double Resultado { get; set; }
    }
}
