using Blazor.Aplicacion.Core.Base.Excepciones;
using System;

namespace Blazor.Aplicacion.Core.Users.Registro.Excepciones
{
    [Serializable]
    internal class NombreNullException : BaseException
    {
        public NombreNullException()
        {
        }

        public NombreNullException(string message) : base(message)
        {
        }

        public NombreNullException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}