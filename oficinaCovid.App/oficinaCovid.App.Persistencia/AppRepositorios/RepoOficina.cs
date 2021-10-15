using System;
using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
      public class RepoOficina : IRepoOficina
      {
            private readonly AppContext _appContext;

            public RepoOficina(AppContext appContext)
            {
                  _appContext = appContext;
            }

            IEnumerable<Oficina> IRepoOficina.GetAllOficinas()
            {
                  return _appContext.Oficinas;
            }

            Oficina IRepoOficina.AddOficina(Oficina oficina)
            {
                  var oficinaAdicionado = _appContext.Oficinas.Add(oficina);
                  _appContext.SaveChanges();
                  return oficinaAdicionado.Entity;
            }
            Oficina IRepoOficina.GetOficina(int idOficina)
            {
                  return _appContext.Oficinas.FirstOrDefault(p => p.Id == idOficina);
            }

            Oficina IRepoOficina.UpdateOficina(Oficina oficina)
            {
                  var oficinaEncontrado = _appContext.Oficinas.FirstOrDefault(p => p.Id == oficina.Id);
                  if (oficinaEncontrado != null)
                  {
                        oficinaEncontrado.Numero = oficina.Numero;
                        oficinaEncontrado.Aforo = oficina.Aforo;
                        oficinaEncontrado.Secretario = oficina.Secretario;

                        _appContext.SaveChanges();
                  }

                  return oficinaEncontrado;
            }

            void IRepoOficina.DeleteOficina(int idOficina)
            {
                  var oficinaEncontrado = _appContext.Oficinas.FirstOrDefault(p => p.Id == idOficina);
                  if (oficinaEncontrado == null)
                        return;
                  _appContext.Oficinas.Remove(oficinaEncontrado);
                  _appContext.SaveChanges();
            }
      }
}