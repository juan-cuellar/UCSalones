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
    public class EliminarPersonalAseoModel : PageModel
    {
        private readonly IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());

        [BindProperty]
        public PersonalAseo PersonalAseo { get; set; }

        public IActionResult OnGet(int personalAseoId)
        {
            PersonalAseo = _repoPersonalAseo.GetPersonalAseo(personalAseoId);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoPersonalAseo.DeletePersonalAseo(PersonalAseo.id);
            return RedirectToPage("./Personas");
        }
    }
}
