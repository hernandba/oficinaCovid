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
    public class OficinaModel : PageModel
    {   
        public readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        public readonly IRepositorioOficina _repoOficina = new RepositorioOficina(new oficinaCovid.App.Persistencia.AppContext());
        [BindProperty]
        public Gobernacion gobernacion {get; set;}
        [BindProperty]
        public IEnumerable<Oficina> oficinas {get; set;}
        [BindProperty]
        public Oficina oficina {get; set;}

        public IActionResult OnGet(int? gobernacionid)
        {
            if (gobernacionid.HasValue)
            {   
                oficinas = _repoOficina.GetAll();
                gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
                
                if (gobernacion != null)
                {
                    return Page();
                } else {
                    return RedirectToPage("../../Gobernacion/List");
                }
            } else {
                return RedirectToPage("../../Gobernacion/List");
            }
        }
    }
}
