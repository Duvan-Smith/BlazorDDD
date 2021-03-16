using Blazor.Dominio.Films;
using Blazor.Dominio.Operaciones.Division;
using Blazor.Dominio.Users;
using Capacitacion.Dominio.Core.Base;
using Microsoft.EntityFrameworkCore;
using System;

namespace Blazor.Infraestructura.Datos.Persistencia.Base
{
    public interface IContextDb : IUnitOfWork, IDisposable
    {
        DbSet<FilmEntity> Film { get; }
        DbSet<UserEntity> User { get; }
        DbSet<DivisionEntity> Divisiones { get; }
    }
}