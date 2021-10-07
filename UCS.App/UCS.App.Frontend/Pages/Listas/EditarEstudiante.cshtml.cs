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
    public class EditarEstudianteModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        
        [BindProperty]
        public Estudiante Estudiante{get;set;}

        public IActionResult OnGet(int? Estudianteid)
        {
            if (Estudianteid.HasValue)
            {
                Estudiante = _repoEstudiante.GetEstudiante(Estudianteid.Value);
            }
            else
            {
                Estudiante = new Estudiante();
            }
            
            if(Estudiante==null)
            {
                return RedirectToPage("./Personas");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
                //return RedirectToPage("./Personas");
            }else{
               
                if (Estudiante.id > 0)
                {
                    Estudiante = _repoEstudiante.UpdateEstudiante(Estudiante);
                }else{
                    _repoEstudiante.AddEstudiante(Estudiante);
                }

                return RedirectToPage("./Personas");
            }

        }
    }
}
