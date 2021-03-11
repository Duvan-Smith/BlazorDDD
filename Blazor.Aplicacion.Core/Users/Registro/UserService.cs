using Blazor.Aplicacion.Dto.UsersDto.Registro;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Users.Registro
{
    public class UserService : IUserService
    {
        public bool ActualizarUser(UserRequestDto request)
        {
            throw new NotImplementedException();
        }
        public Task<Guid?> AgregarUser(UserRequestDto request)
        {
            throw new NotImplementedException();
        }
        public bool EliminarUser(UserRequestDto request)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<UserRequestDto> GetAllUser()
        {
            throw new NotImplementedException();
        }
        public UserRequestDto GetUser(Guid request)
        {
            throw new NotImplementedException();
        }
    }
}
