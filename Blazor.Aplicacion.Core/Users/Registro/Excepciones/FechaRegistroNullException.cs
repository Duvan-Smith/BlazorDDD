using Blazor.Aplicacion.Core.Base.Excepciones;
using System;

namespace Blazor.Aplicacion.Core.Users.Registro.Excepciones
{
    [Serializable]
    internal class FechaRegistroNullException : BaseException
    {
        public FechaRegistroNullException()
        {
        }

        public FechaRegistroNullException(string message) : base(message)
        {
        }

        public FechaRegistroNullException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}