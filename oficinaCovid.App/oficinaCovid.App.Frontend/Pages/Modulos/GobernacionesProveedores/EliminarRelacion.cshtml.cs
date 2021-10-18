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
    public class EliminarRelacionModel : PageModel
    {   
         private readonly IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRespositorioGobernacionesProveedores _repoGP = new RespositorioGobernacionesProveedores(new oficinaCovid.App.Persistencia.AppContext());

        [BindProperty]
        public IEnumerable<PersonalProveedor> proveedores {get; set;}
        
        [BindProperty]
        public PersonalProveedor proveedor {get; set;}
        
        [BindProperty]
        public Gobernacion gobernacion {get; set;}
        
        [BindProperty]
        public GobernacionProveedor gProveedor {get; set;}
        public IActionResult OnGet(int? gobernacionid, int? proveedorid)
        {   
            gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
            if (gobernacion != null)
            {
                _repoGP.DeleteProveedorInGobernacion(proveedorid.Value, gobernacion.id);
            }
            return RedirectToPage("./List",new {gobernacionid=gobernacion.id});
        }
    }
}
