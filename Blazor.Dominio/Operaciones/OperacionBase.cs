using Blazor.Dominio.Base;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Dominio.Operaciones
{
    public class OperacionBase : EntidadBase
    {
        [Key]
        public int IdOperacion { get; set; }
        public int Resultado { get; set; }
        
    }
}
