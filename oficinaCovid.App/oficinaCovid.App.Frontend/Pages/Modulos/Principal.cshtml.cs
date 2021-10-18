using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using oficinaCovid.App.Dominio;
using oficinaCovid.App.Persistencia;

namespace oficinaCovid.App.Frontend.Pages
{
    public class PrincipalModel : PageModel
    {   
        public readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        [BindProperty]
        public Gobernacion gobernacion {get; set;}

        public IActionResult OnGet(int? gobernacionid)
        {
            if (gobernacionid.HasValue)
                gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
            else
                gobernacion = new Gobernacion();

            if (gobernacion != null)
                return Page();
            
            return RedirectToPage("../Gobernacion/List");
        }
    }
}
