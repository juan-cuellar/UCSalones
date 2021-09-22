using System.Runtime.InteropServices;
using UCS.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace UCS.App.Persistencia.AppRepositorio
{
    public class RepositorioSistemaIngresoPersonal : IRepositorioSistemaIngresoPersonal
    {
        private readonly AppContext _appContext;

        public RepositorioSistemaIngresoPersonal(AppContext appContext)
        {
            _appContext = appContext;
        }

        public SistemaIngresoPersonal AddSistemaIngresoPersonal(SistemaIngresoPersonal SistemaIngresoPersonal)
        {
            var SistemaIngresoPersonalAdicionado = _appContext.SistemaIngresoPersonal.Add(SistemaIngresoPersonal);
            _appContext.SaveChanges();
            //return Adicionado;
            return SistemaIngresoPersonalAdicionado.Entity;
        }

        public void DeleteSistemaIngresoPersonal(int idSistemaIngresoPersonal)
        {
            var SistemaIngresoPersonalEncontrado = _appContext.SistemaIngresoPersonal.FirstOrDefault(p => p.id == idSistemaIngresoPersonal);
            if (SistemaIngresoPersonalEncontrado == null)
                return;
            _appContext.SistemaIngresoPersonal.Remove(SistemaIngresoPersonalEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<SistemaIngresoPersonal> GetAllSistemaIngresoPersonal()
        {
            return _appContext.SistemaIngresoPersonal;
        }

        public SistemaIngresoPersonal GetSistemaIngresoPersonal(int idSistemaIngresoPersonal)
        {
            var SistemaIngresoPersonalEncontrado= _appContext.SistemaIngresoPersonal.FirstOrDefault(p => p.id == idSistemaIngresoPersonal);
            return SistemaIngresoPersonalEncontrado;
        }

        public SistemaIngresoPersonal UpdateSistemaIngresoPersonal(SistemaIngresoPersonal SistemaIngresoPersonal)
        {
            var SistemaIngresoPersonalEncontrado = _appContext.SistemaIngresoPersonal.FirstOrDefault(p => p.id == SistemaIngresoPersonal.id);
            if (SistemaIngresoPersonalEncontrado != null)
            {
                SistemaIngresoPersonalEncontrado.horayFechaIngreso = SistemaIngresoPersonal.horayFechaIngreso;
                SistemaIngresoPersonalEncontrado.horayFechaSalida = SistemaIngresoPersonal.horayFechaSalida;
                SistemaIngresoPersonalEncontrado.sede = SistemaIngresoPersonal.sede;
                SistemaIngresoPersonalEncontrado.sintomas =SistemaIngresoPersonal.sintomas;
                SistemaIngresoPersonalEncontrado.pruebacovid = SistemaIngresoPersonal.pruebacovid;
                SistemaIngresoPersonalEncontrado.autoriza = SistemaIngresoPersonal.autoriza;

                _appContext.SaveChanges();
            }
            return SistemaIngresoPersonalEncontrado;
        }
    }
}