using Blazor.Dominio.Operaciones.Multiplicacion;
using Blazor.Infraestructura.Datos.Persistencia.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Infraestructura.Datos.Persistencia.Operaciones.Multiplicacion
{
    public class MultiplicacionRepositorio:RepositorioBase<MultiplicacionEntity>, IMultiplicacionRepositorio
    {
        public MultiplicacionRepositorio(IContextDb unitOfWork) : base(unitOfWork) { }
    }
}
