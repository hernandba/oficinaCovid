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
    public class SecretarioModel : PageModel
    {
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioSecretario _repoSecretario = new RepositorioSecretario(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioOficina _repoOficina = new RepositorioOficina(new oficinaCovid.App.Persistencia.AppContext());

        [BindProperty]
        public Gobernacion gobernacion {get; set;}
        [BindProperty]
        public IEnumerable<SecretarioDespacho> secretarios {get; set;}
        [BindProperty]
        public IEnumerable<Oficina> oficinas {get; set;}
        [BindProperty]
        public SecretarioDespacho secretario {get; set;}
        [BindProperty]
        public Oficina oficina {get; set;}
        public IActionResult OnGet(int? secretarioid, int? gobernacionid)
        {
            gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
            if (secretarioid.HasValue)
            {
                secretario = _repoSecretario.GetSecretario(secretarioid.Value);
                if (secretario == null)
                {
                    object routeValues = new {gobernacionid = gobernacion.id};
                    return RedirectToPage("./List", routeValues);
                }
            }
            else
            {
                secretario = new SecretarioDespacho();
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
                if (secretario.id > 0)
                {
                    gobernacion = _repoGobernacion.GetGobernacion(gobernacion.id);
                    _repoSecretario.UpdateSecretario(secretario, gobernacion);
                }
                else
                {
                    gobernacion = _repoGobernacion.GetGobernacion(gobernacion.id);
                    _repoSecretario.AddSecretario(secretario);
                    _repoSecretario.UpdateSecretario(secretario, gobernacion);
                } 
                Object routeValue = new {gobernacionid= gobernacion.id};
                return RedirectToPage("./List", routeValue);
            }
        }
    }
}
