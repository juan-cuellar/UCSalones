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
    public class EditarProfesoresModel : PageModel
    {
        private readonly IRepositorioProfesores _repoProfesores = new RepositorioProfesores(new Persistencia.AppContext());
        
        [BindProperty]
        public Profesores Profesores{get;set;}

        public IActionResult OnGet(int? profesoresid)
        {
            if (profesoresid.HasValue)
            {
                Profesores = _repoProfesores.GetProfesores(profesoresid.Value);
            }
            else
            {
                Profesores = new Profesores();
            }
            
            if(Profesores==null)
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
               
                if (Profesores.id > 0)
                {
                    Profesores = _repoProfesores.UpdateProfesores(Profesores);
                }else{
                    _repoProfesores.AddProfesores(Profesores);
                }

                return RedirectToPage("./Personas");
            }

        }
    }
}
