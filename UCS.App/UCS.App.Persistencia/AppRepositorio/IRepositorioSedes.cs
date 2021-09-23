using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia
{
    public interface IRepositorioSedes
    {
        //FIRMA DE MÉTODOS:
        //GetAllSedes
        IEnumerable<Sedes> GetAllSedes();
        //AddSede
        Sedes AddSedes(Sedes sedes);
        //UpdateSede
        Sedes UpdateSedes(Sedes sedes);
        //DeleteSedes
        void DeleteSedes(int idSedes);
        //GetSedes
        Sedes GetSedes(int idSedes);
    }
}