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
    public class EliminarSecretarioModel : PageModel
    {   
        private readonly IRepositorioSecretario _repoSecretario = new RepositorioSecretario(new oficinaCovid.App.Persistencia.AppContext());

        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        
        [BindProperty]
        public SecretarioDespacho secretario {get; set;}
        
        [BindProperty]
        public Gobernacion gobernacion {get; set;}

        public IActionResult OnGet(int? idsecretario, int? idgobernacion)
        {   
            gobernacion = _repoGobernacion.GetGobernacion(idgobernacion.Value);
            if (gobernacion != null)
            {
                secretario = _repoSecretario.GetSecretario(idsecretario.Value);
                if (secretario != null)
                {
                    _repoSecretario.DeleteSecretario(secretario.id);
                }
                Object routeValue = new {gobernacionid = gobernacion.id};
                return RedirectToPage("./List", routeValue);
            }
            return RedirectToPage("../../Gobernacion/List");
        }
    }
}
