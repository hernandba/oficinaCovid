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
    public class ListModelSecretario : PageModel
    {
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioSecretario _repoSecretario = new RepositorioSecretario(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioOficina _repoOficina = new RepositorioOficina(new oficinaCovid.App.Persistencia.AppContext());

        [BindProperty]
        public Gobernacion gobernacion {get; set;}
        [BindProperty]
        public IEnumerable<SecretarioDespacho> secretarios {get; set;}
        [BindProperty]
        public SecretarioDespacho secretario {get; set;}
        [BindProperty]
        public Oficina oficina {get; set;}

        public IActionResult OnGet(int? gobernacionid)
        {
            if (gobernacionid.HasValue)
            {
                gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
                if (gobernacion != null)
                {
                    secretarios = _repoSecretario.GetAll(gobernacion);
                    return Page();    
                }
                else
                {
                    return RedirectToPage("../../Gobernacion/List");
                }
            }

            return RedirectToPage("../../Gobernacion/List");
        }
    }
}
