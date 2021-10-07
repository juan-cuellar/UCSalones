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
    public class EditarPersonalAseoModel : PageModel
    {

        private readonly IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());

        [BindProperty]
        public PersonalAseo PersonalAseo { get; set; }

        public IActionResult OnGet(int? personalAseoId)
        {
            if (personalAseoId.HasValue)
            {
                PersonalAseo = _repoPersonalAseo.GetPersonalAseo(personalAseoId.Value);
            }
            else
            {
                PersonalAseo = new PersonalAseo();
            }

            if (PersonalAseo == null)
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
            }
            else
            {
                if (PersonalAseo.id > 0)
                {
                    PersonalAseo = _repoPersonalAseo.UpdatePersonalAseo(PersonalAseo);
                }
                else
                {
                    _repoPersonalAseo.AddPersonalAseo(PersonalAseo);
                }
                return RedirectToPage("./Personas");
            }
        }
    }
}
