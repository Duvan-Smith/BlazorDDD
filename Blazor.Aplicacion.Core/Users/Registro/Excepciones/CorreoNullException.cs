using Blazor.Aplicacion.Core.Base.Excepciones;
using System;

namespace Blazor.Aplicacion.Core.Users.Registro.Excepciones
{
    [Serializable]
    internal class CorreoNullException : BaseException
    {
        public CorreoNullException()
        {
        }

        public CorreoNullException(string message) : base(message)
        {
        }

        public CorreoNullException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}