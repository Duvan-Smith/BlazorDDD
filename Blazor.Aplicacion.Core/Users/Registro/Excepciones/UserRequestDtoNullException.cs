using Blazor.Aplicacion.Core.Base.Excepciones;
using System;

namespace Blazor.Aplicacion.Core.Users.Registro.Excepciones
{
    [Serializable]
    internal class UserRequestDtoNullException : BaseException
    {
        public UserRequestDtoNullException()
        {
        }
        public UserRequestDtoNullException(string message) : base(message)
        {
        }
        public UserRequestDtoNullException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}