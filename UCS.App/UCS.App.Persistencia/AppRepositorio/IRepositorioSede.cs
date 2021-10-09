using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia
{
    public interface IRepositorioSede
    {
        //FIRMA DE MÉTODOS:
        //GetAllSede
        IEnumerable<Sede> GetAllSedes();
        //AddSede
        Sede AddSede(Sede sede);
        //UpdateSede
        Sede UpdateSede(Sede sede);
        //DeleteSede
        void DeleteSede(int idSede);
        //GetSede
        Sede GetSede(int idSede);
    }
}