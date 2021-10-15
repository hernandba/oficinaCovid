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
    public class PersonalAseoModel : PageModel
    {
        private readonly IRepositorioAseador _repoAseador = new RepositorioAseador(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());

        [BindProperty]
        public IEnumerable<PersonalAseo> aseadores {get; set;}
        
        [BindProperty]
        public PersonalAseo aseador {get; set;}
        
        [BindProperty]
        public Gobernacion gobernacion {get; set;}
        public IActionResult OnGet(int? gobernacionid, int? aseadorid)
        {   
            gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
            if (gobernacion != null)
            {
                if (aseadorid.HasValue)
                {
                    aseador = _repoAseador.GetAseador(aseadorid.Value);
                }
                else
                {
                    aseador = new PersonalAseo();
                } 
                return Page();
            }
            Object routeValue = new {gobernacionid = gobernacion.id};
            return RedirectToRoute("./List", routeValue);
        }

        public IActionResult OnPost()
        {   
            
            int gobernacionid = gobernacion.id;
            //gobernacion = _repoGobernacion.GetGobernacion(gobernacionid);
            if (aseador.id > 0)
            {
                _repoAseador.UpdateAseador(aseador, gobernacionid);
            } 
            else
            {
                _repoAseador.AddAseador(aseador);
                _repoAseador.UpdateAseador(aseador, gobernacionid);
            }
            Object routeValue = new {gobernacionid = gobernacionid};
            return RedirectToPage("./List", routeValue);
        }
    }
}
