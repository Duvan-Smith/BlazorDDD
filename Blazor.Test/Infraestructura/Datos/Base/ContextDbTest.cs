using Blazor.Infraestructura.Datos.Persistencia.Base;
using Blazor.Infraestructura.Datos.Persistencia.Base.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Xunit.Categories;

namespace Blazor.Test.Infraestructura.Datos.Base
{
    public class ContextDbTest
    {
        [Fact]
        [UnitTest]
        public void Check_functions_ContextoDb_implements_EntidadBase()
        {
            //var contextDbMock = new Mock<IContextDb>();

            //var film = new FilmEntity();

            var service = new ServiceCollection();
            service.ConfigureBaseRepository(new DbSettings());
            var provider = service.BuildServiceProvider();
            var contextDbService = provider.GetRequiredService<IContextDb>();

            _ = Assert.IsAssignableFrom<DbContext>(contextDbService);
            _ = Assert.IsAssignableFrom<IContextDb>(contextDbService);
            // TODO: Este test deberia permitir evaluar cualquier tipo de entidad no solo una
            //_ = Assert.IsAssignableFrom<EntidadBase>(contextDbService.Set<It.IsAny<EntidadBase>()>());
            //_ = Assert.IsAssignableFrom<EntidadBase>(contextDbService.Set<EntidadBase>());
            //_ = Assert.IsAssignableFrom<EntidadBase>(_ = contextDbMock.Setup(m => m.Set<EntidadBase>()));
            //_ = Assert.IsAssignableFrom<EntidadBase>(_ = contextDbMock.Setup(m => m.SetAttach(It.IsAny<EntidadBase>())));
            //_ = Assert.IsAssignableFrom<EntidadBase>(_ = contextDbMock.Setup(m => m.SetDeatached(It.IsAny<EntidadBase>())));
            //_ = Assert.IsAssignableFrom<EntidadBase>(_ = contextDbMock.Setup(m => m.SetModified(It.IsAny<EntidadBase>())));
        }
    }
}
