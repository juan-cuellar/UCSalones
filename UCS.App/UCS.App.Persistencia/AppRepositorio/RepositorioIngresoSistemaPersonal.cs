using System;
using UCS.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
                SistemaIngresoPersonalEncontrado.sedes = SistemaIngresoPersonal.sedes;
                SistemaIngresoPersonalEncontrado.persona = SistemaIngresoPersonal.persona;
                SistemaIngresoPersonalEncontrado.salones = SistemaIngresoPersonal.salones;
                SistemaIngresoPersonalEncontrado.pruebacovid = SistemaIngresoPersonal.pruebacovid;
                SistemaIngresoPersonalEncontrado.autoriza = SistemaIngresoPersonal.autoriza;

                _appContext.SaveChanges();
            }
            return SistemaIngresoPersonalEncontrado;
        }


        IEnumerable<SistemaIngresoPersonal> IRepositorioSistemaIngresoPersonal.GetSistemaIngresoPersonalConSede(NombreFacultad nombreFacultad)
        {
            return _appContext.SistemaIngresoPersonal.Where(s=>s.sedes.Any(n=>n.nombreFacultad==nombreFacultad)).ToList();
        }

        IEnumerable<SistemaIngresoPersonal> IRepositorioSistemaIngresoPersonal.GetSistemaIngresoPesonalConPersona(EstadoCovid EstadoCovid)
        {
            return _appContext.SistemaIngresoPersonal.Where(p=>p.persona.Any(n=>n.EstadoCovid==EstadoCovid)).ToList();
        }

        //  IEnumerable<SistemaIngresoPersonal> IRepositorioSistemaIngresoPersonal.GetSistemaIngresoPersonalConSedeYPersona(NombreFacultad nombreFacultad,EstadoCovid EstadoCovid)
        //  {
        //      return _appContext.SistemaIngresoPersonal.Where(s=>s.sedes, p=>p.persona.Any(n=>n.EstadoCovid==EstadoCovid && n.nombreFacultad==nombreFacultad)).ToList();
        //  }
    }
}