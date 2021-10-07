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
    public class EliminarDirectivoModel : PageModel
    {
        private readonly IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        
        [BindProperty]
        public Directivo Directivo{get;set;}


        public IActionResult OnGet(int Directivoid)
        {
            Directivo = _repoDirectivo.GetDirectivo(Directivoid);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoDirectivo.DeleteDirectivo(Directivo.id);
            return RedirectToPage("./Personas");
        }
    }
}
