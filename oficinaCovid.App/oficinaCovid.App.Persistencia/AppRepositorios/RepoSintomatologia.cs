using System;
using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
      public class RepoSintomatologia : IRepoSintomatologia
      {
            private readonly AppContext _appContext;

            public RepoSintomatologia(AppContext appContext)
            {
                  _appContext = appContext;
            }

            IEnumerable<Sintomatologia> IRepoSintomatologia.GetAllSintomatologias()
            {
                  return _appContext.Sintomatologias;
            }

            Sintomatologia IRepoSintomatologia.AddSintomatologia(Sintomatologia sintomatologia)
            {
                  var sintomatologiaAdicionado = _appContext.Sintomatologias.Add(sintomatologia);
                  _appContext.SaveChanges();
                  return sintomatologiaAdicionado.Entity;
            }
            Sintomatologia IRepoSintomatologia.GetSintomatologia(int idSintomatologia)
            {
                  return _appContext.Sintomatologias.FirstOrDefault(p => p.Id == idSintomatologia);
            }

            Sintomatologia IRepoSintomatologia.UpdateSintomatologia(Sintomatologia sintomatologia)
            {
                  var sintomatologiaEncontrado = _appContext.Sintomatologias.FirstOrDefault(p => p.Id == sintomatologia.Id);
                  if (sintomatologiaEncontrado != null)
                  {
                        sintomatologiaEncontrado.Fiebre = sintomatologia.Fiebre;
                        sintomatologiaEncontrado.PerdidaOlfato = sintomatologia.PerdidaOlfato;
                        sintomatologiaEncontrado.PerdidaGusto = sintomatologia.PerdidaGusto;
                        sintomatologiaEncontrado.TosSeca = sintomatologia.TosSeca;
                        sintomatologiaEncontrado.Desaliento = sintomatologia.Desaliento;
                        sintomatologiaEncontrado.DolorGarganta = sintomatologia.DolorGarganta;
                        sintomatologiaEncontrado.DificultadRespirar = sintomatologia.DificultadRespirar;

                        _appContext.SaveChanges();
                  }

                  return sintomatologiaEncontrado;
            }

            void IRepoSintomatologia.DeleteSintomatologia(int idSintomatologia)
            {
                  var sintomatologiaEncontrado = _appContext.Sintomatologias.FirstOrDefault(p => p.Id == idSintomatologia);
                  if (sintomatologiaEncontrado == null)
                        return;
                  _appContext.Sintomatologias.Remove(sintomatologiaEncontrado);
                  _appContext.SaveChanges();
            }
      }
}