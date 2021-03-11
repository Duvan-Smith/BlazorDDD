using Blazor.Aplicacion.Core.Mapper.Configuration;
using Blazor.Aplicacion.Core.Users.FachadaUser;
using Blazor.Aplicacion.Core.Users.InicioSesion;
using Blazor.Aplicacion.Core.Users.Registro;
using Blazor.Infraestructura.Datos.Persistencia.Base.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Blazor.Aplicacion.Core.Users.Base.Configuration
{
    public static class FachadaConfigurator
    {
        public static void ConfigureFachadaUserService(this IServiceCollection services, DbSettings settings)
        {
            services.TryAddTransient<IUserService, UserService>();
            services.TryAddTransient<IFachadaUserService, FachadaUserService>();
            services.TryAddTransient<IInicioSesionService, InicioSesionService>();
            services.ConfigureMapper();
            services.ConfigureBaseRepository(settings);
        }
    }
}
