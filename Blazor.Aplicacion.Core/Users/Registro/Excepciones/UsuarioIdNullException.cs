using Blazor.Aplicacion.Core.Base.Excepciones;
using System;

namespace Blazor.Aplicacion.Core.Users.Registro.Excepciones
{
    [Serializable]
    internal class UsuarioIdNullException : BaseException
    {
        public UsuarioIdNullException()
        {
        }

        public UsuarioIdNullException(string message) : base(message)
        {
        }

        public UsuarioIdNullException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}