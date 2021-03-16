using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blazor.Dominio.Operaciones.Division
{
    public class DivisionEntity: OperacionBase
    {
        public double Dividendo { get; set; }
        public double Divisor { get; set; }

    }
}
