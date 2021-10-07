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
    public class DetallesPersonalAseoModel : PageModel
    {
        private readonly IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        
        public PersonalAseo PersonalAseo{get;set;}
        
        public IActionResult OnGet(int personalAseoid)
        {
            PersonalAseo = _repoPersonalAseo.GetPersonalAseoId(personalAseoid);
            if(PersonalAseo==null)
            {
                return RedirectToPage("./Personas");
            }
            else
                return Page();
        }
    }
}
