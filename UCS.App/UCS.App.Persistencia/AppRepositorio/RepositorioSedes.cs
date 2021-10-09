using UCS.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace UCS.App.Persistencia
{
    public class RepositorioSede : IRepositorioSede
    {
        private readonly AppContext _appContext;

        public RepositorioSede(AppContext appContext)
        {
           
            _appContext = appContext;
        }

        Sede IRepositorioSede.AddSede(Sede sede)
        {
            var sedeAdicionado = _appContext.Sede.Add(sede);
            _appContext.SaveChanges();
            return sedeAdicionado.Entity;
        }

        Sede IRepositorioSede.UpdateSede(Sede sede)
        {
            var sedeEncontrado = _appContext.Sede.FirstOrDefault(p => p.id == sede.id);
            if (sedeEncontrado != null)
            {
                sedeEncontrado.nombreFacultad = sede.nombreFacultad;
                sedeEncontrado.salonesDisponibles = sede.salonesDisponibles;

                _appContext.SaveChanges();
            }
            return sedeEncontrado;
            
        }

        void IRepositorioSede.DeleteSede(int idSede)
        {
            var sedeEncontrado = _appContext.Sede.FirstOrDefault(p => p.id == idSede);
            if (sedeEncontrado == null)
                return;
            _appContext.Sede.Remove(sedeEncontrado);
            _appContext.SaveChanges();
        }

        Sede IRepositorioSede.GetSede(int idSede)
        {
            var sedeEncontrado = _appContext.Sede.FirstOrDefault(p => p.id == idSede);
            return sedeEncontrado;
        }

        IEnumerable<Sede> IRepositorioSede.GetAllSedes()
        {
            return _appContext.Sede;
        } 
    }
}