using System;
using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
      public class RepoAseador : IRepoAseador
      {
            private readonly AppContext _appContext;

            public RepoAseador(AppContext appContext)
            {
                  _appContext = appContext;
            }

            IEnumerable<Aseador> IRepoAseador.GetAllAseadores()
            {
                  return _appContext.Aseadores;
            }

            Aseador IRepoAseador.AddAseador(Aseador aseador)
            {
                  var aseadorAdicionado = _appContext.Aseadores.Add(aseador);
                  _appContext.SaveChanges();
                  return aseadorAdicionado.Entity;
            }
            Aseador IRepoAseador.GetAseador(int idAseador)
            {
                  return _appContext.Aseadores.FirstOrDefault(p => p.Id == idAseador);
            }

            Aseador IRepoAseador.UpdateAseador(Aseador aseador)
            {
                  var aseadorEncontrado = _appContext.Aseadores.FirstOrDefault(p => p.Id == aseador.Id);
                  if (aseadorEncontrado != null)
                  {
                        aseadorEncontrado.Identificacion = aseador.Identificacion;
                        aseadorEncontrado.Nombres = aseador.Nombres;
                        aseadorEncontrado.Apellidos = aseador.Apellidos;
                        aseadorEncontrado.Edad = aseador.Edad;
                        aseadorEncontrado.Genero = aseador.Genero;
                        aseadorEncontrado.Diagnosticos = aseador.Diagnosticos;

                        _appContext.SaveChanges();
                  }

                  return aseadorEncontrado;
            }

            void IRepoAseador.DeleteAseador(int idAseador)
            {
                  var aseadorEncontrado = _appContext.Aseadores.FirstOrDefault(p => p.Id == idAseador);
                  if (aseadorEncontrado == null)
                        return;
                  _appContext.Aseadores.Remove(aseadorEncontrado);
                  _appContext.SaveChanges();
            }
      }
}