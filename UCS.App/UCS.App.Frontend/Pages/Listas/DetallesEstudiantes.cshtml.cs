using System;
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
    public class DetallesEstudiantesModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        
        public Estudiante Estudiante{get;set;}
        
        public IActionResult OnGet(int Estudianteid)
        {
            Estudiante = _repoEstudiante.GetEstudianteId(Estudianteid);
            if(Estudiante==null)
            {
                return RedirectToPage("./Personas");
            }
            else
                return Page();
        }
    }
}
