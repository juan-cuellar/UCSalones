using System.Collections.Generic;
using System.Linq;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private readonly AppContext _appContext;

        public RepositorioEstudiante(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Estudiante AddEstudiante(Estudiante Estudiante)
        {
            var estudianteAdicionado = _appContext.Estudiantes.Add(Estudiante);
            _appContext.SaveChanges();
            //return Adicionado;
            return estudianteAdicionado.Entity;
        }

        public void DeleteEstudiante(int idEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
            if (estudianteEncontrado == null)
                return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Estudiante> GetAllEstudiante()
        {
            return _appContext.Estudiantes;
        }

        public Estudiante GetEstudiante(int idEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
            return estudianteEncontrado;
        }

        public Estudiante UpdateEstudiante(Estudiante Estudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == Estudiante.id);
            if(estudianteEncontrado!=null){
                estudianteEncontrado.nombre = Estudiante.nombre;
                estudianteEncontrado.apellido = Estudiante.apellido;
                estudianteEncontrado.identificacion = Estudiante.identificacion;
                estudianteEncontrado.edad =Estudiante.edad;
                estudianteEncontrado.EstadoCovid = Estudiante.EstadoCovid;
                estudianteEncontrado.sintomas = Estudiante.sintomas;
                estudianteEncontrado.carrera = Estudiante.carrera;
                estudianteEncontrado.Semestre = Estudiante.Semestre;
                
                _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        }

         public Estudiante GetEstudianteId(int idEstudiante)
        {
            return _appContext.Estudiantes.SingleOrDefault(p=>p.id==idEstudiante);
        }
    }

}