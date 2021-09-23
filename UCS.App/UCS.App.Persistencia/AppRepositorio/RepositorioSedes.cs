using UCS.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace UCS.App.Persistencia
{
    public class RepositorioSedes : IRepositorioSedes
    {
        private readonly AppContext _appContext;

        public RepositorioSedes(AppContext appContext)
        {
           
            _appContext = appContext;
        }

        Sedes IRepositorioSedes.AddSedes(Sedes sedes)
        {
            var sedesAdicionado = _appContext.Sedes.Add(sedes);
            _appContext.SaveChanges();
            return sedesAdicionado.Entity;
        }

        Sedes IRepositorioSedes.UpdateSedes(Sedes sedes)
        {
            var sedesEncontrado = _appContext.Sedes.FirstOrDefault(p => p.id == sedes.id);
            if (sedesEncontrado != null)
            {
                sedesEncontrado.nombreFacultad = sedes.nombreFacultad;
                sedesEncontrado.salonesDisponibles = sedes.salonesDisponibles;

                _appContext.SaveChanges();
            }
            return sedesEncontrado;
            
        }

        void IRepositorioSedes.DeleteSedes(int idSedes)
        {
            var sedesEncontrado = _appContext.Sedes.FirstOrDefault(p => p.id == idSedes);
            if (sedesEncontrado == null)
                return;
            _appContext.Sedes.Remove(sedesEncontrado);
            _appContext.SaveChanges();
        }

        Sedes IRepositorioSedes.GetSedes(int idSedes)
        {
            var sedesEncontrado = _appContext.Sedes.FirstOrDefault(p => p.id == idSedes);
            return sedesEncontrado;
        }

        IEnumerable<Sedes> IRepositorioSedes.GetAllSedes()
        {
            return _appContext.Sedes;
        } 
    }
}