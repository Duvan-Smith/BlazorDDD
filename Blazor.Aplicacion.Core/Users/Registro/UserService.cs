using Blazor.Aplicacion.Dto.UsersDto.Registro;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Users.Registro
{
    public class UserService : IUserService
    {
        public bool UpdateUser(UserRequestDto request)
        {
            throw new NotImplementedException();
        }
        public Task<Guid?> InsertUser(UserRequestDto request)
        {
            throw new NotImplementedException();
        }
        public bool DeleteUser(UserRequestDto request)
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
