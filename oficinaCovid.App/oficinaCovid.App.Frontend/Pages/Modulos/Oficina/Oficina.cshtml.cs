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
    public class OficinaModel : PageModel
    {   
        public readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        public readonly IRepositorioOficina _repoOficina = new RepositorioOficina(new oficinaCovid.App.Persistencia.AppContext());
        private static IRepositorioSecretario _repoSecretario = new RepositorioSecretario(new oficinaCovid.App.Persistencia.AppContext());
        
        [BindProperty]
        public Gobernacion gobernacion {get; set;}

        [BindProperty]
        public IEnumerable<Oficina> oficinas {get; set;}
        
        [BindProperty]
        public IEnumerable<SecretarioDespacho> secretarios {get; set;}

        [BindProperty]
        public Oficina oficina {get; set;}

        [BindProperty]
        public SecretarioDespacho secretario {get; set;}
        public IActionResult OnGet(int? oficinaid, int? gobernacionid)
        {
            gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
            secretarios = _repoSecretario.GetAllSecretarioGobernacion(gobernacion);
            if (oficinaid.HasValue)
            {   
                oficina = _repoOficina.GetOficina(oficinaid.Value);
                secretario = _repoSecretario.GetSecretarioOficina(oficina);
            }
            else
            {
                oficina = new Oficina();
                secretario = null;
            }

            if (oficina == null)
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
                if (oficina.id > 0)
                {
                    gobernacion = _repoGobernacion.GetGobernacion(gobernacion.id);
                    secretario = _repoSecretario.GetSecretario(secretario.id);
                    _repoOficina.UpdateOficina(oficina, gobernacion, secretario);
                }
                else
                {
                    gobernacion = _repoGobernacion.GetGobernacion(gobernacion.id);
                    secretario = _repoSecretario.GetSecretario(secretario.id);
                    _repoOficina.AddOficina(oficina, gobernacion);
                    _repoOficina.UpdateOficina(oficina, gobernacion, secretario);
                } 
                Object routeValue = new {gobernacionid= gobernacion.id};
                return RedirectToPage("./List", routeValue);
            }

           
        }
    }
}
