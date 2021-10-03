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

        Diagnostico IRepositorioDiagnostico.UpdateDiagnostico(Diagnostico diagnostico)
        {
            var diagnosticoEncontrado = _appContext.diagnosticos.FirstOrDefault(x => x.id == diagnostico.id);
            if (diagnosticoEncontrado != null)
            {
                diagnosticoEncontrado.persona = diagnostico.persona;
                diagnosticoEncontrado.infectado = diagnostico.infectado;
                diagnosticoEncontrado.fechaDiagnostico = diagnostico.fechaDiagnostico;
                diagnosticoEncontrado.fechaFinAislamiento = diagnostico.fechaFinAislamiento;
                diagnosticoEncontrado.sintomas = diagnostico.sintomas;
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