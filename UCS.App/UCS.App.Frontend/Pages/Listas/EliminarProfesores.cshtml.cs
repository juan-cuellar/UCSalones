using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UCS.App.Persistencia;
using UCS.App.Dominio;

namespace UCS.App.Frontend.Pages
{
    public class EliminarProfesoresModel : PageModel
    {

        private readonly IRepositorioProfesores _repoProfesores = new RepositorioProfesores(new Persistencia.AppContext());
        
        [BindProperty]
        public Profesores Profesores{get;set;}


        public IActionResult OnGet(int profesoresid)
        {
            Profesores = _repoProfesores.GetProfesores(profesoresid);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoProfesores.DeleteProfesores(Profesores.id);
            return RedirectToPage("./Personas");
        }
    }
}
