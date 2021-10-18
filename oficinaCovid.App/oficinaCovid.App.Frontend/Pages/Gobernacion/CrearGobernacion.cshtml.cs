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
    public class CrearGobernacionModel : PageModel
    {   
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        [BindProperty]
        public Gobernacion gobernacion {get; set;}

        public IActionResult OnGet(int? gobernacionid)
        {
            if (gobernacionid.HasValue)
            {
                gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
            }
            else
            {
                gobernacion = new Gobernacion();
            }

            if (gobernacion == null)
            {
                return RedirectToPage("./List");
            }
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
                if (gobernacion.id > 0)
                {
                    _repoGobernacion.UpdateGobernacion(gobernacion);
                }
                else
                {
                    _repoGobernacion.AddGobernacion(gobernacion);
                }
                return RedirectToPage("./List");
            }
            
        }
    }
}
