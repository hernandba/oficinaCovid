using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using oficinaCovid.App.Dominio;
using oficinaCovid.App.Persistencia;

namespace oficinaCovid.App.Frontend
{
    public class ListModel : PageModel
    {   
        public readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        public IEnumerable<Gobernacion> Gobernaciones {get; set;}
        public Gobernacion Gobernacion {get; set;}

        public void OnGet()
        {
            Gobernaciones = _repoGobernacion.GetAll();
        }
    }
}
