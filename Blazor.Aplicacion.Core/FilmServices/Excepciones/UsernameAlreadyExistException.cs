using Blazor.Aplicacion.Core.Base.Excepciones;

namespace Blazor.Aplicacion.Core.FilmServices.Excepciones
{
    public class UsernameAlreadyExistException : BaseException
    {
        public UsernameAlreadyExistException()
        {
        }

        public UsernameAlreadyExistException(string message) : base(message)
        {
        }
    }
}