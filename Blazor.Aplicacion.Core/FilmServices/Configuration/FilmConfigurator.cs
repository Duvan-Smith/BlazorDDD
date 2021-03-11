using Blazor.Aplicacion.Core.Mapper.Configuration;
using Blazor.Infraestructura.Datos.Persistencia.Base.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Blazor.Aplicacion.Core.FilmServices.Configuration
{
    public static class FilmConfigurator
    {
        public static void ConfigureFilmService(this IServiceCollection services, DbSettings settings)
        {
            services.TryAddTransient<IFilmService, FilmService>();
            services.ConfigureMapper();
            services.ConfigureBaseRepository(settings);
        }
    }
}