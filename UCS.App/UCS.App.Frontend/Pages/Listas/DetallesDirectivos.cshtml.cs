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
    public class DetallesDirectivosModel : PageModel
    {
        private readonly IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        
        public Directivo Directivo{get;set;}
        
        public IActionResult OnGet(int directivoid)
        {
            Directivo = _repoDirectivo.GetDirectivoId(directivoid);
            if(Directivo==null)
            {
                return RedirectToPage("./Personas");
            }
            else
                return Page();
        }
    }
}
