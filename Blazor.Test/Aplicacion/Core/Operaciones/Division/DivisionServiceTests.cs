using Blazor.Aplicacion.Core.Operaciones.Base.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Blazor.Infraestructura.Datos.Persistencia.Base.Configuration;
using Blazor.Aplicacion.Dto.OperacionesDto.DivisionDtos;
using Xunit;
using Xunit.Categories;
using Blazor.Aplicacion.Core.Operaciones.Division;
using System.Threading.Tasks;

namespace Blazor.Test.Aplicacion.Core.Operaciones.Division
{
    public class DivisionServiceTests
    {

        [Fact]
        [UnitTest]

        public async Task SuccesfullDivisionTest() {
            var service = new ServiceCollection();
            service.ConfigureOperacionesService(new DbSettings());
            var provider = service.BuildServiceProvider();
            var divisionService = provider.GetRequiredService<IDivisionService>();
            var result = await divisionService.Dividir(new DivisionRequestDto { Dividendo = 2, Divisor = 2 }).ConfigureAwait(false);
            Assert.Equal( 1.0, result.Resultado );
        }
    }
}
