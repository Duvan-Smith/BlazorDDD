using Blazor.Aplicacion.Dto.OperacionesDto.DivisionDtos;
using Blazor.Infraestructura.Datos.Persistencia.Operaciones.Division;
using System.Threading.Tasks;
using System;
using Blazor.Dominio.Operaciones.Division;
using AutoMapper;

namespace Blazor.Aplicacion.Core.Operaciones.Division
{
    public class DivisionService : IDivisionService
    {

        private readonly IDivisionRepository divisionRepository;
        private readonly IMapper _mapper;

        public DivisionService(IDivisionRepository _repo, IMapper _mapper) {
            this.divisionRepository = _repo;
            this._mapper = _mapper;
        }
        public async Task<DivisionResponseDto> Dividir(DivisionRequestDto RequestDto)
        {
            var result = RequestDto.Dividendo/ RequestDto.Divisor;
            RequestDto.Resultado = result;
            var response = await divisionRepository.Insert(_mapper.Map<DivisionEntity>(RequestDto)).ConfigureAwait(false);

            return new DivisionResponseDto
            {
                Resultado = response.Resultado
            };
        }
    }
}
