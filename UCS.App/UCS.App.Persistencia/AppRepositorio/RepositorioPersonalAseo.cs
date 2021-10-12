using System.Collections.Generic;
using System.Linq;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public class RepositorioPersonalAseo : IRepositorioPersonalAseo
    {
        private readonly AppContext _appContext;

        public RepositorioPersonalAseo(AppContext appContext)
        {
            _appContext = appContext;
        }

        public PersonalAseo AddPersonalAseo(PersonalAseo PersonalAseo)
        {
            var PersonalAseoAdicionado = _appContext.PersonaldeAseo.Add(PersonalAseo);
            _appContext.SaveChanges();
            //return Adicionado;
            return PersonalAseoAdicionado.Entity;
        }

        public void DeletePersonalAseo(int idPersonalAseo)
        {
            var PersonalAseoEncontrado = _appContext.PersonaldeAseo.FirstOrDefault(p => p.id == idPersonalAseo);
            if (PersonalAseoEncontrado == null)
                return;
            _appContext.PersonaldeAseo.Remove(PersonalAseoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<PersonalAseo> GetAllPersonalAseo()
        {
            return _appContext.PersonaldeAseo;
        }

        public PersonalAseo GetPersonalAseo(int idPersonalAseo)
        {
            var PersonalAseoEncontrado = _appContext.PersonaldeAseo.FirstOrDefault(p => p.id == idPersonalAseo);
            return PersonalAseoEncontrado;
        }

        public PersonalAseo UpdatePersonalAseo(PersonalAseo PersonalAseo)
        {
             var PersonalAseoEncontrado = _appContext.PersonaldeAseo.FirstOrDefault(p => p.id == PersonalAseo.id);
            if(PersonalAseoEncontrado!=null){
                PersonalAseoEncontrado.nombre = PersonalAseo.nombre;
                PersonalAseoEncontrado.apellido = PersonalAseo.apellido;
                PersonalAseoEncontrado.identificacion = PersonalAseo.identificacion;
                PersonalAseoEncontrado.edad =PersonalAseo.edad;
                PersonalAseoEncontrado.EstadoCovid = PersonalAseo.EstadoCovid;
                PersonalAseoEncontrado.sintomas = PersonalAseo.sintomas;
                PersonalAseoEncontrado.turnoServicio = PersonalAseo.turnoServicio;
                                
                _appContext.SaveChanges();
            }
            return PersonalAseoEncontrado;
        }
        public PersonalAseo GetPersonalAseoId(int idPersonalAseo)
        {
            return _appContext.PersonaldeAseo.SingleOrDefault(p=>p.id==idPersonalAseo);
        }
        
    }

}