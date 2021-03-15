using Blazor.Dominio.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blazor.Dominio.Operaciones.Multiplicacion
{
    public class MultiplicacionEntity : OperacionBase
    {
        [Key]
        public Guid IdMultiplicacion { get; set; }

        [Required]
        public int Factor1 { get; set; }

        [Required]
        public int Factor2 { get; set; }

    }
}
