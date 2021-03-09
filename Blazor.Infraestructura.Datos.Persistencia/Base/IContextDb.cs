using Blazor.Dominio.Films;
using Capacitacion.Dominio.Core.Base;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blazor.Infraestructura.Datos.Persistencia.Base
{
    public interface IContextDb : IUnitOfWork, IDisposable
    {
        DbSet<FilmEntity> Film { get; }
    }
}