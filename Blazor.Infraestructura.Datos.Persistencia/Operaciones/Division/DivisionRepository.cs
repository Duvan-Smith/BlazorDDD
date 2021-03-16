using Blazor.Dominio.Operaciones.Division;
using Blazor.Infraestructura.Datos.Persistencia.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Infraestructura.Datos.Persistencia.Operaciones.Division
{
    public class DivisionRepository : RepositorioBase<DivisionEntity>, IDivisionRepository {

        public DivisionRepository(IContextDb unitOfWork) : base(unitOfWork) 
        {         
        }
        
    }
}
