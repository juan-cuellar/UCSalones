using UCS.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace UCS.App.Persistencia
{
    public class RepositorioProfesores : IRepositorioProfesores
    {
        private readonly AppContext _appContext;

        public RepositorioProfesores(AppContext appContext)
        {
           
            _appContext = appContext;
        }

        Profesores IRepositorioProfesores.AddProfesores(Profesores profesores)
        {
            var profesoresAdicionado = _appContext.Profesores.Add(profesores);
            _appContext.SaveChanges();
            return profesoresAdicionado.Entity;
        }

        Profesores IRepositorioProfesores.UpdateProfesores(Profesores profesores)
        {
            var profesoresEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id == profesores.id);
            if (profesoresEncontrado != null)
            {
                profesoresEncontrado.nombre = profesores.nombre;
                profesoresEncontrado.apellido = profesores.apellido;
                profesoresEncontrado.identificacion = profesores.identificacion;
                profesoresEncontrado.edad = profesores.edad;
                profesoresEncontrado.EstadoCovid = profesores.EstadoCovid;
                profesoresEncontrado.sintomas = profesores.sintomas;
                profesoresEncontrado.departamento = profesores.departamento;
                profesoresEncontrado.materia = profesores.materia;

                _appContext.SaveChanges();
            }
            else{
                Console.WriteLine("Error: No se pudo actualizar Profesor con Id: " + profesores.id);
            }
            return profesoresEncontrado;
            
        }

        void IRepositorioProfesores.DeleteProfesores(int idProfesores)
        {
            var profesoresEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id == idProfesores);
            if (profesoresEncontrado == null)
                return;
            _appContext.Profesores.Remove(profesoresEncontrado);
            _appContext.SaveChanges();
        }

        Profesores IRepositorioProfesores.GetProfesores(int idProfesores)
        {
            var profesoresEncontrado = _appContext.Profesores.FirstOrDefault(p => p.id == idProfesores);
            return profesoresEncontrado;
        }

        IEnumerable<Profesores> IRepositorioProfesores.GetAllProfesores()
        {
            return _appContext.Profesores;
        } 

        public Profesores GetProfesoresId(int idProfesores)
        {
            return _appContext.Profesores.SingleOrDefault(p=>p.id==idProfesores);
        }
        
    }
}