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
    public class EliminarGobernacionModel : PageModel
    {
        private static IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        [BindProperty]
        public Gobernacion gobernacion {get; set;}

        public IActionResult OnGet(int gobernacionid)
        {
            gobernacion = _repoGobernacion.GetGobernacion(gobernacionid);
            if (gobernacion != null)
            {
                _repoGobernacion.DeleteGobernacion(gobernacion.id);
            }
            return RedirectToPage("./List");
        }
    }
}
