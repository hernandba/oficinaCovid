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
    public class ProveedoresGobernacionesModel : PageModel
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
        public IActionResult OnGet(int? gobernacionid)
        {
            if (gobernacionid.HasValue)
            {
                gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
                proveedores = _repoGP.GetProveedoresNotInGobernacion(gobernacionid.Value);
                proveedor = new PersonalProveedor();
                return Page();
            }
            return RedirectToPage("../../Gobernacion/List");
        }

        public IActionResult OnPost()
        {   
            gProveedor = new GobernacionProveedor{
                proveedorId = proveedor.id,
                gobernacionId = gobernacion.id
            };
            proveedor = _repoProveedor.GetProveedor(proveedor.id);
            gobernacion = _repoGobernacion.GetGobernacion(gobernacion.id);
            if (proveedor != null)
            {
                _repoGP.AddProveedorInGobernacion(gProveedor);
                _repoGP.UpdateProveedorInGobernacion(gobernacion.id, proveedor.id);
            }

            return RedirectToPage("./List", new {gobernacionid = gobernacion.id});
        }
    }
}
