using Blazor.Aplicacion.Core.Base.Excepciones;
using System;

namespace Blazor.Aplicacion.Core.Users.Registro.Excepciones
{
    [Serializable]
    internal class ApellidoNullException : BaseException
    {
        public ApellidoNullException()
        {
        }

        public ApellidoNullException(string message) : base(message)
        {
        }

        public ApellidoNullException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}