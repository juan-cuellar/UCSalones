using System.Runtime.InteropServices;
using UCS.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace UCS.App.Persistencia.AppRepositorio

{
    public class RepositorioDirectivo : IRepositorioDirectivo
    {
        private readonly AppContext _appContext;

        public RepositorioDirectivo(AppContext appContext)
        {
            _appContext = appContext;
        }

        Directivo IRepositorioDirectivo.AddDirectivo(Directivo directivo)
        {
            var directivoAdicionado = _appContext.Directivos.Add(directivo);
            _appContext.SaveChanges();
            //return Adicionado;
            return directivoAdicionado.Entity;
        }

        Directivo IRepositorioDirectivo.UpdateDirectivo (Directivo directivo)
        {
            var directivoEncontrado = _appContext.Directivos.FirstOrDefault(p => p.id == directivo.id);
            if (directivoEncontrado != null)
            {
                directivoEncontrado.nombre = directivo.nombre;
                directivoEncontrado.apellido = directivo.apellido;
                directivoEncontrado.identificacion = directivo.identificacion;
                directivoEncontrado.edad =directivo.edad;
                directivoEncontrado.EstadoCovid = directivo.EstadoCovid;
                directivoEncontrado.unidadDesempeña = directivo.unidadDesempeña;
                directivoEncontrado.sintomas = directivo.sintomas;

                _appContext.SaveChanges();
            }
            return directivoEncontrado;
        }

        void IRepositorioDirectivo.DeleteDirectivo (int idDirectivo)
        {
            var directivoEncontrado = _appContext.Directivos.FirstOrDefault(p => p.id == idDirectivo);
            if (directivoEncontrado == null)
                return;
            _appContext.Directivos.Remove(directivoEncontrado);
            _appContext.SaveChanges();
        }

        Directivo IRepositorioDirectivo.GetDirectivo(int idDirectivo)
        {
            var directivoEncontrado= _appContext.Directivos.FirstOrDefault(p => p.id == idDirectivo);
            return directivoEncontrado;
        }

        IEnumerable<Directivo> IRepositorioDirectivo.GetAllDirectivo()
        {
            return _appContext.Directivos;
        }

        public Directivo GetDirectivoId(int idDirectivo)
        {
            return _appContext.Directivos.SingleOrDefault(p=>p.id==idDirectivo);
        }
    }
}