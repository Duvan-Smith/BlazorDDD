using Blazor.Aplicacion.Dto.Base;
using System;

namespace Blazor.Aplicacion.Dto.FilmsDto
{
    public class FilmRequestDto : DataTransferObject
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
    }
}