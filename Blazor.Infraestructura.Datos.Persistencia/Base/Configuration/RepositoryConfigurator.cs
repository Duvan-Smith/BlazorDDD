using Blazor.Dominio.Films;
using Blazor.Infraestructura.Datos.Persistencia.Films;
using Capacitacion.Infraestructura.Datos.Persistencia.Core.Base;
using Capacitacion.Infraestructura.Datos.Persistencia.Core.Base.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Blazor.Infraestructura.Datos.Persistencia.Base.Configuration
{
    public static class RepositoryConfigurator
    {
        public static void ConfigureBaseRepository(this IServiceCollection services, DbSettings settings)
        {
            services.TryAddTransient<IFilmRepositorio, FilmRepositorio>();

            services.ConfigureContext(settings);
        }

        public static void ConfigureContext(this IServiceCollection services, DbSettings settings)
        {
            services.Configure<DbSettings>(o => o.CopyFrom(settings));
            services.TryAddScoped<IContextDb, ContextoDb>();
        }
    }
}