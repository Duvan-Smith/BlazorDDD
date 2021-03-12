using Blazor.Aplicacion.Dto.Base;
using Blazor.Aplicacion.Dto.UsersDto.Registro;
using Xunit;
using Xunit.Categories;

namespace Blazor.Test.Aplicacion.Dto.Users.Registro
{
    public class UserDtosTest
    {
        [Fact]
        [UnitTest]
        public void Check_Dtos_UserAdd_implements_DataTransferObject()
        {
            var usertDto = new UserDto();
            var userRequestDto = new UserRequestDto();
            var userResponseDto = new UserResponseDto();

            _ = Assert.IsAssignableFrom<DataTransferObject>(usertDto);
            _ = Assert.IsAssignableFrom<UserDto>(userRequestDto);
            _ = Assert.IsAssignableFrom<DataTransferObject>(userResponseDto);
        }
    }
}
