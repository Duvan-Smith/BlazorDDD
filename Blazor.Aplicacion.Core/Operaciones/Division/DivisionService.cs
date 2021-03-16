using AutoMapper;
using Blazor.Aplicacion.Dto.OperacionesDto.DivisionDtos;
using Blazor.Dominio.Operaciones.Division;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Operaciones.Division
{
    public class DivisionService : IDivisionService
    {

        private readonly IDivisionRepository divisionRepository;
        private readonly IMapper _mapper;

        public DivisionService(IDivisionRepository _repo, IMapper _mapper)
        {
            this.divisionRepository = _repo;
            this._mapper = _mapper;
        }
        public async Task<DivisionResponseDto> Dividir(DivisionRequestDto RequestDto)
        {
            var result = RequestDto.Dividendo / RequestDto.Divisor;
            RequestDto.Resultado = result;
            RequestDto.IdOperacion = Guid.NewGuid();
            var response = await divisionRepository.Insert(_mapper.Map<DivisionEntity>(RequestDto)).ConfigureAwait(false);

            return new DivisionResponseDto
            {
                IdOperacion = response.IdOperacion,
                Resultado = response.Resultado,
                StatusCode = response != null ? HttpStatusCode.OK : HttpStatusCode.Unauthorized,
                StatusDescription = response != null ? "Correo existe y esta activo" : "El correo no existe o esta innactivo"
            };
        }
    }
}
