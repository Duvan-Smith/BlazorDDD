using System;

namespace Blazor.Aplicacion.Core.Base.Excepciones
{
    public class SypException : Exception
    {
        public SypException()
        {
        }

        public SypException(string message) : base(message)
        {
        }
    }
}