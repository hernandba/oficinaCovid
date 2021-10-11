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
    public class EliminarOficinaModel : PageModel
    {   
        private readonly IRepositorioOficina _repoOficina = new RepositorioOficina(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        [BindProperty]
        public Oficina oficina {get; set;}
        [BindProperty]
        public Gobernacion gobernacion {get; set;}

        public IActionResult OnGet(int? oficinaid, int? gobernacionid)
        {
            gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
            if (gobernacion != null)
            {
                oficina = _repoOficina.GetOficina(oficinaid.Value);
                if (oficina != null)
                {
                    _repoOficina.DeleteOficina(oficina.id);
                }
                Object routeValue = new {gobernacionid = gobernacion.id};
                return RedirectToPage("./List", routeValue);
            }
            return RedirectToPage("../../Gobernacion/List");
        }
    }
}
