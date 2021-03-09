using Blazor.Dominio.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Dominio.Films
{
    public class FilmEntity : EntidadBase
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public DateTimeOffset ReleaseDate { get; set; }
    }
}