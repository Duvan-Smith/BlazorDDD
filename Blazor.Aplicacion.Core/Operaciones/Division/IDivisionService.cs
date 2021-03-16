using Blazor.Aplicacion.Dto.OperacionesDto.DivisionDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Operaciones.Division
{
    public interface IDivisionService
    {
        public Task<DivisionResponseDto> Dividir(DivisionRequestDto RequestDto);
    }
}
