using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public interface IRepositorioUniversidad
    {
        //CRUD
        //GetAllUniversidad
        IEnumerable<Universidad> GetAllUniversidad();
        //AddUniversidad
        Universidad AddUniversidad(Universidad Universidad);
        //UptadateUniversidad
        Universidad UpdateUniversidad(Universidad Universidad);
        //DeleteUniversidad
        void DeleteUniversidad(int idUniversidad);
        //GetUniversidad
        Universidad GetUniversidad(int idUniversidad);
    }

}