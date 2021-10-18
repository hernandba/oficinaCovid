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
    public class EliminarModel : PageModel
    {   
        private readonly IRepositorioAseador _repoAseador = new RepositorioAseador(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());        
        
        [BindProperty]
        public PersonalAseo aseador {get; set;}
        public IActionResult OnGet(int? aseadorid, int? gobernacionid)
        {
            aseador = _repoAseador.GetAseador(aseadorid.Value);
            if (aseador != null)
            {
                _repoAseador.DeleteAseador(aseador.id);
            }

            Object routeValue = new {gobernacionid = gobernacionid};
            return RedirectToPage("./List", routeValue);
        }
    }
}
