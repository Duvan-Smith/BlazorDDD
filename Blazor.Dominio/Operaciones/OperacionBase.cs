using Blazor.Dominio.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Dominio.Operaciones
{
    public class OperacionBase : EntidadBase
    {
        [Key]
        public Guid IdOperacion { get; set; }
        public double Resultado { get; set; }
    }
}
