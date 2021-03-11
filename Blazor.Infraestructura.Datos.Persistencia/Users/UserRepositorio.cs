using Blazor.Dominio.Users;
using Blazor.Infraestructura.Datos.Persistencia.Base;

namespace Blazor.Infraestructura.Datos.Persistencia.Users
{
    public class UserRepositorio : RepositorioBase<UserEntity>, IUserRepositorio
    {
        public UserRepositorio(IContextDb unitOfWork) : base(unitOfWork)
        {
        }
    }
}
