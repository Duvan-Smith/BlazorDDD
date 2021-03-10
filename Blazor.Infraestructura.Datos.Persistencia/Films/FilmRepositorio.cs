using Blazor.Dominio.Films;
using Blazor.Infraestructura.Datos.Persistencia.Base;

namespace Blazor.Infraestructura.Datos.Persistencia.Films
{
    public class FilmRepositorio : RepositorioBase<FilmEntity>, IFilmRepositorio
    {
        public FilmRepositorio(IContextDb unitOfWork) : base(unitOfWork)
        {
        }
    }
}