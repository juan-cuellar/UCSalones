using System.Collections.Generic;
using System.Linq;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public class RepositorioUniversidad : IRepositorioUniversidad
    {

        private readonly AppContext _appContext;

        public RepositorioUniversidad(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Universidad AddUniversidad(Universidad Universidad)
        {
            var UniversidadAdicionado = _appContext.Universidades.Add(Universidad);
            _appContext.SaveChanges();
            //return Adicionado;
            return UniversidadAdicionado.Entity;
        }

        public void DeleteUniversidad(int idUniversidad)
        {
            var UniversidadesEncontrado = _appContext.Universidades.FirstOrDefault(p => p.id == idUniversidad);
            if (UniversidadesEncontrado == null)
                return;
            _appContext.Universidades.Remove(UniversidadesEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Universidad> GetAllUniversidad()
        {
            return _appContext.Universidades;
        }

        public Universidad GetUniversidad(int idUniversidad)
        {
            var UniversidadesEncontrado = _appContext.Universidades.FirstOrDefault(p => p.id == idUniversidad);
            return UniversidadesEncontrado;
        }

        public Universidad UpdateUniversidad(Universidad Universidad)
        {
            var UniversidadesEncontrado = _appContext.Universidades.FirstOrDefault(p => p.id == Universidad.id);
            if (UniversidadesEncontrado != null)
            {
                UniversidadesEncontrado.id = Universidad.id;
                UniversidadesEncontrado.nit = Universidad.nit;
                UniversidadesEncontrado.direccion = Universidad.direccion;

                _appContext.SaveChanges();
            }
            return UniversidadesEncontrado;
        }
    }
}