using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public interface IRepositorioEstudiante
    {
         //CRUD
        //GetAllEstudiante
        IEnumerable<Estudiante> GetAllEstudiante();
        //AddEstudiante
        Estudiante AddEstudiante(Estudiante Estudiante);
        //UptadateEstudiante
        Estudiante UpdateEstudiante(Estudiante Estudiante);
        //DeleteEstudiante
        void DeleteEstudiante(int idEstudiante);
        //GetEstudiante
        Estudiante GetEstudiante(int idEstudiante);
    }
}