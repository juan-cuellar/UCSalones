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
    public class DetallesProfesoresModel : PageModel
    {
        private readonly IRepositorioProfesores _repoProfesores = new RepositorioProfesores(new Persistencia.AppContext());
        
        public Profesores Profesores{get;set;}
        
        public IActionResult OnGet(int profesoresid)
        {
            Profesores = _repoProfesores.GetProfesoresId(profesoresid);
            if(Profesores==null)
            {
                return RedirectToPage("./Personas");
            }
            else
                return Page();
        }
    }
}
