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
    public class EditarDirectivoModel : PageModel
    {
        private readonly IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        
        [BindProperty]
        public Directivo Directivo{get;set;}

        public IActionResult OnGet(int? Directivoid)
        {
            if (Directivoid.HasValue)
            {
                Directivo = _repoDirectivo.GetDirectivo(Directivoid.Value);
            }
            else
            {
                Directivo = new Directivo();
            }
            
            if(Directivo==null)
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
               
                if (Directivo.id > 0)
                {
                    Directivo = _repoDirectivo.UpdateDirectivo(Directivo);
                }else{
                    _repoDirectivo.AddDirectivo(Directivo);
                }

                return RedirectToPage("./Personas");
            }

        }
    }
}
