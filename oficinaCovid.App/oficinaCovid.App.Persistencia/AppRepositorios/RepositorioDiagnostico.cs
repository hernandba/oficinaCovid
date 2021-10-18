using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class RepositorioDiagnostico : IRepositorioDiagnostico
    {
        private readonly AppContext _appContext;

        public RepositorioDiagnostico(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Diagnostico> IRepositorioDiagnostico.GetAll()
        {
            return _appContext.diagnosticos;
        }

        IEnumerable<Diagnostico> IRepositorioDiagnostico.GetDiagnosticosInPersona(int personaID)
        {
            IEnumerable<Diagnostico> diagnosticos = (from d in _appContext.diagnosticos
                                                     join p in _appContext.personas on d.persona equals p
                                                     where p.id == personaID
                                                     select new Diagnostico{
                                                         id = d.id,
                                                         persona = p,
                                                         infectado = d.infectado,
                                                         fechaDiagnostico = d.fechaDiagnostico,
                                                         diasAislamiento = d.diasAislamiento,
                                                         fechaFinAislamiento = d.fechaFinAislamiento,
                                                         sintomas = d.sintomas
                                                     });
            return diagnosticos;                                                
        }

        Diagnostico IRepositorioDiagnostico.GetDiagnostico(int diagnosticoId)
        {
            var diagnosticoEncontrado = _appContext.diagnosticos.FirstOrDefault(x => x.id == diagnosticoId);
            return diagnosticoEncontrado;
        }

        Diagnostico IRepositorioDiagnostico.AddDiagnostico(Diagnostico diagnostico)
        {
            var diagnosticoAgregado = _appContext.diagnosticos.Add(diagnostico);
            _appContext.SaveChanges();
            return diagnosticoAgregado.Entity;
        }

        Diagnostico IRepositorioDiagnostico.UpdateDiagnostico(Diagnostico diagnostico, int personaID, int sintomasID)
        {   
            SintomasCovid sintomas = _appContext.sintomas.FirstOrDefault(x => x.id == sintomasID);
            Persona persona = _appContext.personas.FirstOrDefault(x => x.id == personaID);
            var diagnosticoEncontrado = _appContext.diagnosticos.FirstOrDefault(x => x.id == diagnostico.id);
            if (diagnosticoEncontrado != null)
            {
                diagnosticoEncontrado.persona = persona;
                diagnosticoEncontrado.infectado = diagnostico.infectado;
                diagnosticoEncontrado.fechaDiagnostico = diagnostico.fechaDiagnostico;
                diagnosticoEncontrado.diasAislamiento = diagnostico.diasAislamiento;
                diagnosticoEncontrado.fechaFinAislamiento = diagnostico.fechaFinAislamiento;
                diagnosticoEncontrado.sintomas = sintomas;
                _appContext.SaveChanges();
            }
            return diagnostico;
        }

        bool IRepositorioDiagnostico.DeleteDiagnostico(int diagnosticoId)
        {
             var diagnosticoEncontrado = _appContext.diagnosticos.FirstOrDefault(x => x.id == diagnosticoId);
            if (diagnosticoEncontrado == null)
                return false;
            _appContext.diagnosticos.Remove(diagnosticoEncontrado);
            _appContext.SaveChanges();
            return true;
        }
    }
}