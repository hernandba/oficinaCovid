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
    public class EliminarDiagnosticoModel : PageModel
    {   
        private readonly IRepositorioDiagnostico _repoDiagnostico = new RepositorioDiagnostico(new oficinaCovid.App.Persistencia.AppContext());
        private readonly IRepositorioSintomas _repoSintomas = new RepositorioSintomas(new oficinaCovid.App.Persistencia.AppContext());
        
        [BindProperty]
        public Diagnostico diagnostico {get; set;}

        [BindProperty]
        public SintomasCovid sintomas {get; set;}

        public IActionResult OnGet(int? diagnosticoid, int? personaid)
        {
            diagnostico = _repoDiagnostico.GetDiagnostico(diagnosticoid.Value);
            if (diagnostico != null)
            {
                sintomas = _repoSintomas.GetSintomasInDiagnostico(diagnostico.id);
                _repoDiagnostico.DeleteDiagnostico(diagnostico.id);
                _repoSintomas.DeleteSintomas(sintomas.id);
            }
            return RedirectToPage("./DiagnosticoList", new {personaid = personaid.Value});
        }
    }
}
