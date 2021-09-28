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
     private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo (new Persistencia.AppContext());
        
        public IEnumerable<Directivo> Directivos {get;set;}
        
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante (new Persistencia.AppContext());
        
        public IEnumerable<Estudiante> Estudiantes {get;set;}
        public void OnGet()
        {
            Directivos = _repoDirectivo.GetAllDirectivo();

            Estudiantes = _repoEstudiante.GetAllEstudiante();    
        }

    }
}
