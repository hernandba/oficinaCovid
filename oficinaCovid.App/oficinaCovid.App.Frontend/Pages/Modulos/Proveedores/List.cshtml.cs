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
    public class ProveedorListModel : PageModel
    {   
        private readonly IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());

        [BindProperty]
        public PersonalProveedor proveedor {get; set;}
        
        [BindProperty]
        public Gobernacion gobernacion {get; set;}
        public void OnGet()
        {
        }
    }
}
