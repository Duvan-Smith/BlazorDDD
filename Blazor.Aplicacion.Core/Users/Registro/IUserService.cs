using Blazor.Aplicacion.Dto.UsersDto.Registro;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Users.Registro
{
    public interface IUserService
    {
        public Task<Guid?> InsertUser(UserRequestDto request);
        public bool DeleteUser(UserRequestDto request);
        public UserRequestDto GetUser(Guid request);
        public IEnumerable<UserRequestDto> GetAllUser();
        public bool UpdateUser(UserRequestDto request);
    }
}
