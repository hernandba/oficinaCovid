using System;
using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
      public class RepoDiagnostico : IRepoDiagnostico
      {
            private readonly AppContext _appContext;

            public RepoDiagnostico(AppContext appContext)
            {
                  _appContext = appContext;
            }

            IEnumerable<Diagnostico> IRepoDiagnostico.GetAllDiagnosticos()
            {
                  return _appContext.Diagnosticos;
            }

            Diagnostico IRepoDiagnostico.AddDiagnostico(Diagnostico diagnostico)
            {
                  var diagnosticoAdicionado = _appContext.Diagnosticos.Add(diagnostico);
                  _appContext.SaveChanges();
                  return diagnosticoAdicionado.Entity;
            }
            Diagnostico IRepoDiagnostico.GetDiagnostico(int idDiagnostico)
            {
                  return _appContext.Diagnosticos.FirstOrDefault(p => p.Id == idDiagnostico);
            }

            Diagnostico IRepoDiagnostico.UpdateDiagnostico(Diagnostico diagnostico)
            {
                  var diagnosticoEncontrado = _appContext.Diagnosticos.FirstOrDefault(p => p.Id == diagnostico.Id);
                  if (diagnosticoEncontrado != null)
                  {
                        diagnosticoEncontrado.Positivo = diagnostico.Positivo;
                        diagnosticoEncontrado.FechaDiagnostico = diagnostico.FechaDiagnostico;
                        diagnosticoEncontrado.DiasAislamiento = diagnostico.DiasAislamiento;
                        diagnosticoEncontrado.FechaFinAislamiento = diagnostico.FechaFinAislamiento;
                        diagnosticoEncontrado.Sintomatologia = diagnostico.Sintomatologia;

                        _appContext.SaveChanges();
                  }

                  return diagnosticoEncontrado;
            }

            void IRepoDiagnostico.DeleteDiagnostico(int idDiagnostico)
            {
                  var diagnosticoEncontrado = _appContext.Diagnosticos.FirstOrDefault(p => p.Id == idDiagnostico);
                  if (diagnosticoEncontrado == null)
                        return;
                  _appContext.Diagnosticos.Remove(diagnosticoEncontrado);
                  _appContext.SaveChanges();
            }
      }
}