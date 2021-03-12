using AutoMapper;
using Blazor.Aplicacion.Core.FilmServices.Excepciones;
using Blazor.Aplicacion.Core.Users.Registro.Excepciones;
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
            CheckParameterUpdateUser(request);
            var entity = _repoUser.SearchMatchingOneResult<UserEntity>(x => x.UsuarioId == request.UsuarioId);
            entity.Nombre = request.Nombre;
            entity.Apellido = request.Apellido;
            entity.Correo = request.Correo;
            entity.Contrasena = request.Contrasena;
            entity.FechaRegistro = request.FechaRegistro;
            entity.Rol = request.Rol;

            return _repoUser.Update(entity);
        }

        private static void CheckParameterUpdateUser(UserRequestDto request)
        {
            if (request == null)
            {
                throw new UserRequestDtoNullException($"El parametro: {nameof(request)} es obligatorio");
            }
            if (request.UsuarioId == default || request?.UsuarioId == null)
            {
                throw new UsuarioIdNullException($"El parametro: {nameof(request.UsuarioId)} es obligatorio");
            }

            if (string.IsNullOrEmpty(request.Nombre))
            {
                throw new NombreNullException($"El parametro: {nameof(request.Nombre)} es obligatorio");
            }
            if (string.IsNullOrEmpty(request.Apellido))
            {
                throw new ApellidoNullException($"El parametro: {nameof(request.Apellido)} es obligatorio");
            }
            if (string.IsNullOrEmpty(request.Correo))
            {
                throw new CorreoNullException($"El parametro: {nameof(request.Correo)} es obligatorio");
            }
            if (string.IsNullOrEmpty(request.Contrasena))
            {
                throw new ContrasenaNullException($"El parametro: {nameof(request.Contrasena)} es obligatorio");
            }
            if (request.FechaRegistro == default || request?.FechaRegistro == null)
            {
                throw new FechaRegistroNullException($"El parametro: {nameof(request.FechaRegistro)} es obligatorio");
            }
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
