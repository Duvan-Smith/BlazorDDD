using System.ComponentModel.DataAnnotations;

namespace Blazor.Dominio.Operaciones.Multiplicacion
{
    public class MultiplicacionEntity : OperacionBase
    {
        [Required]
        public int Factor1 { get; set; }

        [Required]
        public int Factor2 { get; set; }

    }
}
