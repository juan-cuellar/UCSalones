using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public interface IRepositorioSalon
    {
        //CRUD
        //GetAllSalones
        IEnumerable<Salon> GetAllSalones();
        //AddSalon
        Salon AddSalon(Salon Salon);
        //UptadateSalon
        Salon UpdateSalon(Salon Salon);
        //DeleteSalon
        void DeleteSalon(int idSalon);
        //GetSalon
        Salon GetSalon(int idSalon);

        Salon GetSalonConProfesor(int idSalon);
    }
}