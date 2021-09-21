using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia
{
    public interface IRepositorioDirectivo
    {
        //CRUD
        //GetAllDirectivo
        IEnumerable<Directivo> GetAllDirectivo();
        //AddDirectivo
        Directivo AddDirectivo(Directivo directivo);
        //UptadateDirectivo
        Directivo UpdateDirectivo(Directivo directivo);
        //DeleteDirectivo
        void DeleteDirectivo(int idDirectivo);
        //GetDirectivo
        Directivo GetDirectivo(int idDirectivo);
    }
}