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
    public class ProveedoresModel : PageModel
    {   
        private readonly IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new oficinaCovid.App.Persistencia.AppContext());

        [BindProperty]
        public IEnumerable<PersonalProveedor> proveedores {get; set;}
        
        [BindProperty]
        public PersonalProveedor proveedor {get; set;}
        
        [BindProperty]
        public Gobernacion gobernacion {get; set;}
        public IActionResult OnGet(int? proveedorid)
        {   
            if (proveedorid.HasValue)
            {
                proveedor = _repoProveedor.GetProveedor(proveedorid.Value);
            }
            
            if (proveedor == null)
            {
                proveedor = new PersonalProveedor();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (proveedor.id > 0)
            {
                _repoProveedor.UpdateProveedor(proveedor);
            }
            else
            {
                _repoProveedor.AddProveedor(proveedor);
            }
            return RedirectToPage("./List");
        }
    }
}
