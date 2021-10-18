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
    public class GobernadorEliminarModel : PageModel
    {
        private readonly IRepositorioGobernadorAsesor _repoGobernador = new RepositorioGobernadorAsesor(new oficinaCovid.App.Persistencia.AppContext());
        
        [BindProperty]
        public GobernadorAsesor gobernador {get; set;}

        public IActionResult OnGet(int? gobernadorid, int? gobernacionid)
        {
            if (gobernadorid.HasValue)
            {
                _repoGobernador.DeleteGA(gobernadorid.Value);
            }
            return RedirectToPage("./List", new {gobernacionid = gobernacionid});
            
        }
    }
}
