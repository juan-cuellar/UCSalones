using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UCS.App.Persistencia;
using UCS.App.Dominio;
using UCS.App.Persistencia.AppRepositorio;

namespace UCS.App.Frontend.Pages
{
    public class EliminarEstudianteModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        
        [BindProperty]
        public Estudiante Estudiante{get;set;}


        public IActionResult OnGet(int Estudianteid)
        {
            Estudiante = _repoEstudiante.GetEstudiante(Estudianteid);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoEstudiante.DeleteEstudiante(Estudiante.id);
            return RedirectToPage("./Personas");
        }
    }
}
