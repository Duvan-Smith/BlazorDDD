using Blazor.Aplicacion.Core.Base.Excepciones;
using System;

namespace Blazor.Aplicacion.Core.Users.Registro.Excepciones
{
    [Serializable]
    internal class ContrasenaNullException : BaseException
    {
        public ContrasenaNullException()
        {
        }

        public ContrasenaNullException(string message) : base(message)
        {
        }

        public ContrasenaNullException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}