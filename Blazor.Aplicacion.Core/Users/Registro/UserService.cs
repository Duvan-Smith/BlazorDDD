using AutoMapper;
using Blazor.Aplicacion.Core.FilmServices.Excepciones;
using Blazor.Aplicacion.Dto.UsersDto.Registro;
using Blazor.Dominio.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Aplicacion.Core.Users.Registro
{
    public class UserService : IUserService
    {
        private readonly IUserRepositorio _repoUser;
        private readonly IMapper _mapper;

        public UserService(IUserRepositorio repoUser, IMapper mapper)
        {
            _mapper = mapper;
            _repoUser = repoUser;
        }
        public bool UpdateUser(UserRequestDto request)
        {
            var entity = _repoUser.SearchMatchingOneResult<UserEntity>(x => x.UsuarioId == request.UsuarioId);
            entity.Nombre = request.Nombre;
            entity.Apellido = request.Apellido;
            entity.Correo = request.Correo;
            entity.Contrasena = request.Contrasena;
            entity.FechaRegistro = request.FechaRegistro;
            entity.Rol = request.Rol;

            return _repoUser.Update(entity);
        }
        public async Task<Guid?> InsertUser(UserRequestDto request)
        {
            var usernameExist = _repoUser
                .SearchMatching<UserEntity>(x => x.Correo == request.Correo)
                .Any();

            if (usernameExist)
                throw new UsernameAlreadyExistException(request.Correo);

            var response = await _repoUser.Insert(_mapper.Map<UserEntity>(request)).ConfigureAwait(false);

            return response.UsuarioId;
        }
        public bool DeleteUser(UserRequestDto request)
        {
            var entity = _mapper.Map<UserEntity>(request);
            return _repoUser.Delete(entity);
        }
        public UserRequestDto GetUser(UserRequestDto request)
        {
            var user = _repoUser
                .SearchMatching<UserEntity>(x => x.UsuarioId == request.UsuarioId);
            return _mapper.Map<UserRequestDto>(user.FirstOrDefault());
        }
        public IEnumerable<UserRequestDto> GetAllUser()
        {
            var user = _repoUser
                .GetAll<UserEntity>();
            return _mapper.Map<IEnumerable<UserRequestDto>>(user);
        }
    }
}
