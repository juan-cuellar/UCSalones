using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public interface IRepositorioPersonalAseo
    {
         //CRUD
        //GetAllPersonalAseo
        IEnumerable<PersonalAseo> GetAllPersonalAseo();
        //AddPersonalAseo
        PersonalAseo AddPersonalAseo(PersonalAseo PersonalAseo);
        //UptadatePersonalAseo
        PersonalAseo UpdatePersonalAseo(PersonalAseo PersonalAseo);
        //DeletePersonalAseo
        void DeletePersonalAseo(int idPersonalAseo);
        //GetPersonalAseo
        PersonalAseo GetPersonalAseo(int idPersonalAseo);
        PersonalAseo GetPersonalAseoId(int idPersonalAseo);
        
    }
}