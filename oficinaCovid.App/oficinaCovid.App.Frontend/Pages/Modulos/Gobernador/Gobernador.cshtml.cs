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
    public class GobernadorModel : PageModel
    {
        private readonly IRepositorioGobernadorAsesor _repoGobernador = new RepositorioGobernadorAsesor(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        
        [BindProperty]
        public IEnumerable<GobernadorAsesor> gobernadores {get; set;}
        
        [BindProperty]
        public GobernadorAsesor gobernador {get; set;}

        [BindProperty]
        public Gobernacion gobernacion {get; set;}
        public IActionResult OnGet(int? gobernadorid, int? gobernacionid)
        {   
            if (gobernacion.HasValue){
                gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
                if (gobernacion != null)
                {
                    gobernador = _repoGobernador.GetGA(gobernadorid.Value);
                    Object routeValue = new {gobernacionid = gobernacion.id};
                    
                    if (gobernador == null)
                    {
                        gobernador = new GobernadorAsesor();
                        return RedirectToPage("./List", routeValue);
                    }
                    return Page();
                }
                return RedirectToPage("../../Gobernacion/List");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (gobernador.id > 0)
            {
                _repoGobernador.UpdateGA(gobernador, gobernacion.id);
            }
            else 
            {
                _repoGobernador.AddGA(gobernador);
                _repoGobernador.UpdateGA(gobernador, gobernacion.id);
            }
            return RedirectToPage("./List", new {gobernacionid=gobernacion.id});
        }
    }
}
