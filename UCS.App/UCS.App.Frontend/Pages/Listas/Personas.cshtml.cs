using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UCS.App.Dominio;
using UCS.App.Persistencia;
using UCS.App.Persistencia.AppRepositorio;

namespace UCS.App.Frontend.Pages
{
    public class PersonasModel : PageModel
    {
        private readonly IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());

        public IEnumerable<Directivo> Directivos { get; set; }

        private readonly IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());

        public IEnumerable<Estudiante> Estudiantes { get; set; }

        private readonly IRepositorioProfesores _repoProfesor = new RepositorioProfesores(new Persistencia.AppContext());

        public IEnumerable<Profesores> Profesores { get; set; }

        private readonly IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());

        public IEnumerable<PersonalAseo> PersonaldeAseo { get; set; }

        public void OnGet()
        {
            Directivos = _repoDirectivo.GetAllDirectivo();

            Estudiantes = _repoEstudiante.GetAllEstudiante();

            Profesores = _repoProfesor.GetAllProfesores();

            PersonaldeAseo = _repoPersonalAseo.GetAllPersonalAseo();
        }

        public void OnPost()
        {
            Directivos = _repoDirectivo.GetAllDirectivo();

            Estudiantes = _repoEstudiante.GetAllEstudiante();

            Profesores = _repoProfesor.GetAllProfesores();

            PersonaldeAseo = _repoPersonalAseo.GetAllPersonalAseo();
        }

    }
}
