using Blazor.Aplicacion.Dto.Base;
using Blazor.Aplicacion.Dto.UsersDto.InicioSesion;
using Xunit;
using Xunit.Categories;

namespace Blazor.Test.Aplicacion.Dto.Users.InicioSesion
{
    public class InicioSesionDtosTest
    {
        [Fact]
        [UnitTest]
        public void Check_Dtos_UserLogin_implements_DataTransferObject()
        {
            var inicioSesionRequestDto = new InicioSesionRequestDto();
            var inicioSesionResponseDto = new InicioSesionResponseDto();

            Assert.IsNotType<DataTransferObject>(inicioSesionRequestDto);
            _ = Assert.IsAssignableFrom<DataTransferObject>(inicioSesionResponseDto);
        }
    }
}
