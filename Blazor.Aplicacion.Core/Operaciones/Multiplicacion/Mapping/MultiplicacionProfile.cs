using AutoMapper;
using Blazor.Aplicacion.Dto.OperacionesDto.MultiplicacionDtos;
using Blazor.Dominio.Operaciones.Multiplicacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Aplicacion.Core.Operaciones.Multiplicacion.Mapping
{
    public class MultiplicacionProfile : Profile
    {
        public MultiplicacionProfile() 
        {
            CreateMap<MultiplicacionEntity, MultiplicacionDto>().ReverseMap();
        }
    }
}
