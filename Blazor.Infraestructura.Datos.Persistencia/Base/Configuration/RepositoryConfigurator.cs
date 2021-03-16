using Blazor.Dominio.Films;
using Blazor.Dominio.Operaciones.Division;
using Blazor.Dominio.Operaciones.Multiplicacion;
using Blazor.Dominio.Users;
using Blazor.Infraestructura.Datos.Persistencia.Films;
using Blazor.Infraestructura.Datos.Persistencia.Operaciones.Division;
using Blazor.Infraestructura.Datos.Persistencia.Operaciones.Multiplicacion;
using Blazor.Infraestructura.Datos.Persistencia.Users;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Blazor.Infraestructura.Datos.Persistencia.Base.Configuration
{
    public static class RepositoryConfigurator
    {
        public static void ConfigureBaseRepository(this IServiceCollection services, DbSettings settings)
        {
            services.TryAddTransient<IUserRepositorio, UserRepositorio>();
            services.TryAddTransient<IFilmRepositorio, FilmRepositorio>();
            services.TryAddTransient<IMultiplicacionRepositorio, MultiplicacionRepositorio>();
            services.TryAddTransient<IDivisionRepository, DivisionRepository>();

            services.ConfigureContext(settings);
        }

        public static void ConfigureContext(this IServiceCollection services, DbSettings settings)
        {
            services.Configure<DbSettings>(o => o.CopyFrom(settings));
            services.TryAddScoped<IContextDb, ContextoDb>();
        }
    }
}