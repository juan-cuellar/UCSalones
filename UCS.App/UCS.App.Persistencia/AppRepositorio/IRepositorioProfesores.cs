using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia
{
    public interface IRepositorioProfesores
    {
        //FIRMA DE MÉTODOS:
        //GetAllProfesores
        IEnumerable<Profesores> GetAllProfesores();
        //AddProfesores
        Profesores AddProfesores(Profesores profesores);
        //Update<profesores
        Profesores UpdateProfesores(Profesores profesores);
        //DeleteProfesores
        void DeleteProfesores(int idProfesores);
        //GetProfesores
        Profesores GetProfesores(int idProfesores);
    }
}