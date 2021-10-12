using System.Collections.Generic;
using System.Linq;
using UCS.App.Dominio;
using System;
using Microsoft.EntityFrameworkCore;

namespace UCS.App.Persistencia.AppRepositorio
{
    public class RepositorioSalon : IRepositorioSalon
    {
        private readonly AppContext _appContext;

        public RepositorioSalon(AppContext appContext)
        {
            _appContext = appContext;
        }

        Salon IRepositorioSalon.AddSalon(Salon Salon)
        {
            var SalonAdicionado = _appContext.Salon.Add(Salon);
            _appContext.SaveChanges();
            //return Adicionado;
            return SalonAdicionado.Entity;
        }

        Salon IRepositorioSalon.UpdateSalon (Salon Salon)
        {
            var SalonEncontrado = _appContext.Salon.FirstOrDefault(p => p.id == Salon.id);
            if (SalonEncontrado != null)
            {
                SalonEncontrado.id = Salon.id;
                SalonEncontrado.numeroSalon = Salon.numeroSalon;
                SalonEncontrado.maximoAforo = Salon.maximoAforo;
                SalonEncontrado.maximoAforo =Salon.maximoAforo;
                SalonEncontrado.numeroDePuesto = Salon.numeroDePuesto;
                SalonEncontrado.estudiantes = Salon.estudiantes;
                SalonEncontrado.profesor = Salon.profesor;
                

                _appContext.SaveChanges();
            }
            return SalonEncontrado;
        }

        void IRepositorioSalon.DeleteSalon (int idSalon)
        {
            var SalonEncontrado = _appContext.Salon.FirstOrDefault(p => p.id == idSalon);
            if (SalonEncontrado == null)
                return;
            _appContext.Salon.Remove(SalonEncontrado);
            _appContext.SaveChanges();
        }

        Salon IRepositorioSalon.GetSalon(int idSalon)
        {
            var SalonEncontrado= _appContext.Salon.FirstOrDefault(p => p.id == idSalon);
            return SalonEncontrado;
        }

        IEnumerable<Salon> IRepositorioSalon.GetAllSalones()
        {
            return _appContext.Salon;
        }

        Salon IRepositorioSalon.GetSalonConProfesor(int idSalon)
        {
            var salonEncontrado= _appContext.Salon.Include(p => p.profesor).FirstOrDefault(p=>p.id==idSalon);
            return salonEncontrado;
        }
        


    }
}