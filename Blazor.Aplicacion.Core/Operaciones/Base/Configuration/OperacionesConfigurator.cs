using Blazor.Aplicacion.Core.Mapper.Configuration;
using Blazor.Aplicacion.Core.Operaciones.Division;
using Blazor.Aplicacion.Core.Operaciones.Multiplicacion.Service;
using Blazor.Infraestructura.Datos.Persistencia.Base.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Blazor.Aplicacion.Core.Operaciones.Base.Configuration
{
    public static class OperacionesConfigurator
    {

        public static void ConfigureOperacionesService(this IServiceCollection services, DbSettings settings)
        {
            services.TryAddTransient<IMultiplicacionService, MultiplicacionService>();
            services.TryAddTransient<IDivisionService, DivisionService>();
            services.ConfigureMapper();
            services.ConfigureBaseRepository(settings);
        }
    }
}