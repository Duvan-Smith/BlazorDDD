using System;

namespace Blazor.Aplicacion.Core.Base.Excepciones
{
    public class BaseException : Exception
    {
        public BaseException()
        {
        }

        public BaseException(string message) : base(message)
        {
        }

        public BaseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}