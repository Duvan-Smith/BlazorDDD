using Blazor.Aplicacion.Core.Users.Base.Configuration;
using Blazor.Aplicacion.Core.Users.Registro;
using Blazor.Aplicacion.Core.Users.Registro.Excepciones;
using Blazor.Aplicacion.Dto.UsersDto.Registro;
using Blazor.Infraestructura.Datos.Persistencia.Base.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace Blazor.Test.Aplicacion.Core.Users.Registro
{
    public class UserServiceTest
    {
        [Fact]
        [UnitTest]
        public async Task Check_AllParameterNull_UpdateUser_Exception()
        {
            var service = new ServiceCollection();
            service.ConfigureFachadaUserService(new DbSettings());
            var provider = service.BuildServiceProvider();
            var userService = provider.GetRequiredService<IUserService>();
            await Assert.ThrowsAsync<UserRequestDtoNullException>(() => Task.FromResult(userService.UpdateUser(null))).ConfigureAwait(false);
            await Assert.ThrowsAsync<UsuarioIdNullException>(() => Task.FromResult(userService.UpdateUser(new UserRequestDto
            {
                UsuarioId = Guid.Empty,
            }))).ConfigureAwait(false);
            await Assert.ThrowsAsync<NombreNullException>(() => Task.FromResult(userService.UpdateUser(new UserRequestDto
            {
                UsuarioId = Guid.NewGuid(),
                Nombre = string.Empty,
            }))).ConfigureAwait(false);
            await Assert.ThrowsAsync<NombreNullException>(() => Task.FromResult(userService.UpdateUser(new UserRequestDto
            {
                UsuarioId = Guid.NewGuid(),
                Nombre = null,
            }))).ConfigureAwait(false);
            await Assert.ThrowsAsync<ApellidoNullException>(() => Task.FromResult(userService.UpdateUser(new UserRequestDto
            {
                UsuarioId = Guid.NewGuid(),
                Nombre = "fake",
                Apellido = string.Empty,
            }))).ConfigureAwait(false);
            await Assert.ThrowsAsync<ApellidoNullException>(() => Task.FromResult(userService.UpdateUser(new UserRequestDto
            {
                UsuarioId = Guid.NewGuid(),
                Nombre = "fake",
                Apellido = null,
            }))).ConfigureAwait(false);
            await Assert.ThrowsAsync<CorreoNullException>(() => Task.FromResult(userService.UpdateUser(new UserRequestDto
            {
                UsuarioId = Guid.NewGuid(),
                Nombre = "fake",
                Apellido = "fake",
                Correo = string.Empty,
            }))).ConfigureAwait(false);
            await Assert.ThrowsAsync<CorreoNullException>(() => Task.FromResult(userService.UpdateUser(new UserRequestDto
            {
                UsuarioId = Guid.NewGuid(),
                Nombre = "fake",
                Apellido = "fake",
                Correo = null,
            }))).ConfigureAwait(false);
            await Assert.ThrowsAsync<ContrasenaNullException>(() => Task.FromResult(userService.UpdateUser(new UserRequestDto
            {
                UsuarioId = Guid.NewGuid(),
                Nombre = "fake",
                Apellido = "fake",
                Correo = "fake@fake.fake",
                Contrasena = string.Empty,
            }))).ConfigureAwait(false);
            await Assert.ThrowsAsync<ContrasenaNullException>(() => Task.FromResult(userService.UpdateUser(new UserRequestDto
            {
                UsuarioId = Guid.NewGuid(),
                Nombre = "fake",
                Apellido = "fake",
                Correo = "fake@fake.fake",
                Contrasena = null,
            }))).ConfigureAwait(false);
            await Assert.ThrowsAsync<FechaRegistroNullException>(() => Task.FromResult(userService.UpdateUser(new UserRequestDto
            {
                UsuarioId = Guid.NewGuid(),
                Nombre = "fake",
                Apellido = "fake",
                Correo = "fake@fake.fake",
                Contrasena = "fake",
                FechaRegistro = default
            }))).ConfigureAwait(false);
        }
    }
}
