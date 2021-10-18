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
    public class GobernadoresListModel : PageModel
    {
        private readonly IRepositorioGobernadorAsesor _repoGobernador = new RepositorioGobernadorAsesor(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        
        [BindProperty]
        public IEnumerable<GobernadorAsesor> gobernadores {get; set;}
        
        [BindProperty]
        public GobernadorAsesor gobernador {get; set;}

        [BindProperty]
        public Gobernacion gobernacion {get; set;}
        public IActionResult OnGet(int? gobernacionid)
        {
            if (gobernacionid.HasValue)
            {
                gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
                if (gobernacion != null)
                {
                    gobernadores = _repoGobernador.GetAll(gobernacion.id);
                    return Page();
                }
            }

            return RedirectToPage("../../Gobernacion/List");
        }
    }
}
