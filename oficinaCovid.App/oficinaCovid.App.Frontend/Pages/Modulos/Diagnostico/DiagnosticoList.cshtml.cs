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
    public class DiagnosticoListModel : PageModel
    {
        private readonly IRepositorioAseador _repoAseador = new RepositorioAseador(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioSecretario _repoSecretario =new  RepositorioSecretario(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioGobernadorAsesor _repoGobernador = new RepositorioGobernadorAsesor(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioDiagnostico _repoDiagnostico = new RepositorioDiagnostico(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioSintomas _repoSintomas = new RepositorioSintomas(new oficinaCovid.App.Persistencia.AppContext());

        [BindProperty]
        public PersonalAseo aseador {get; set;}

        [BindProperty]
        public SecretarioDespacho secretario {get; set;}

        [BindProperty]
        public GobernadorAsesor gobernador {get; set;}

        [BindProperty]
        public PersonalProveedor proveedor {get; set;}

        [BindProperty]
        public Diagnostico diagnostico {get; set;}
        
        [BindProperty]
        public IEnumerable<Diagnostico> diagnosticos {get; set;}

        [BindProperty]
        public SintomasCovid sintomas {get; set;}

        public int personaID {get; set;}

        public IActionResult OnGet(int? personaid)
        {    
            aseador = _repoAseador.GetAseador(personaid.Value);
            if (aseador != null)
            {   
                personaID = aseador.id;
            }

            secretario = _repoSecretario.GetSecretario(personaid.Value);
            if (secretario != null)
            {   
                personaID = secretario.id;
            
            }

            gobernador = _repoGobernador.GetGA(personaid.Value);
            if (gobernador != null)
            {
                personaID = gobernador.id;
            }
            
            proveedor = _repoProveedor.GetProveedor(personaid.Value);
            if (proveedor != null)
            {
                personaID = proveedor.id;
            }

            if (personaID > 0)
            {
                diagnosticos = _repoDiagnostico.GetDiagnosticosInPersona(personaID);
                return Page();
            }

            return RedirectToPage("../../Gobernacion/List");
        }
    }
}
