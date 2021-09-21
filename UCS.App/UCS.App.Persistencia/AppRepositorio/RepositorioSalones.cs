using System.Collections.Generic;
using System.Linq;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public class RepositorioSalones : IRepositorioSalones
    {
        private readonly AppContext _appContext;

        public RepositorioSalones(AppContext appContext)
        {
            _appContext = appContext;
        }

        Salones IRepositorioSalones.AddSalones(Salones Salones)
        {
            var SalonesAdicionado = _appContext.Salones.Add(Salones);
            _appContext.SaveChanges();
            //return Adicionado;
            return SalonesAdicionado.Entity;
        }

        Salones IRepositorioSalones.UpdateSalones (Salones Salones)
        {
            var SalonesEncontrado = _appContext.Salones.FirstOrDefault(p => p.id == Salones.id);
            if (SalonesEncontrado != null)
            {
                SalonesEncontrado.id = Salones.id;
                SalonesEncontrado.numeroSalon = Salones.numeroSalon;
                SalonesEncontrado.maximoAforo = Salones.maximoAforo;
                SalonesEncontrado.maximoAforo =Salones.maximoAforo;
                SalonesEncontrado.cantidadActualPersonas = Salones.cantidadActualPersonas;
                

                _appContext.SaveChanges();
            }
            return SalonesEncontrado;
        }

        void IRepositorioSalones.DeleteSalones (int idSalones)
        {
            var SalonesEncontrado = _appContext.Salones.FirstOrDefault(p => p.id == idSalones);
            if (SalonesEncontrado == null)
                return;
            _appContext.Salones.Remove(SalonesEncontrado);
            _appContext.SaveChanges();
        }

        Salones IRepositorioSalones.GetSalones(int idSalones)
        {
            var SalonesEncontrado= _appContext.Salones.FirstOrDefault(p => p.id == idSalones);
            return SalonesEncontrado;
        }

        IEnumerable<Salones> IRepositorioSalones.GetAllSalones()
        {
            return _appContext.Salones;
        }
    }
}