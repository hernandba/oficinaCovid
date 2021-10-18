using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using oficinaCovid.App.Persistencia;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Frontend.Pages
{
    public class AseadoresListModel : PageModel
    {
        private readonly IRepositorioAseador _repoAseador = new RepositorioAseador(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());

        [BindProperty]
        public IEnumerable<PersonalAseo> aseadores {get; set;}
        
        [BindProperty]
        public PersonalAseo aseador {get; set;}
        
        [BindProperty]
        public Gobernacion gobernacion {get; set;}

        public IActionResult OnGet(int? gobernacionid)
        {
            if (gobernacionid.HasValue)
            {
                gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
                if (gobernacion != null)
                {
                    aseadores = _repoAseador.GetAllPersonalAseo(gobernacion.id);
                    return Page();
                }
            }
            return RedirectToPage("../../Gobernacion/List");
        }
    }
}
