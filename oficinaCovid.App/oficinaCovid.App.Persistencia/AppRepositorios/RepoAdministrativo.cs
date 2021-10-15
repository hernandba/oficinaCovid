using System;
using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
      public class RepoAdministrativo : IRepoAdministrativo
      {
            private readonly AppContext _appContext;

            public RepoAdministrativo(AppContext appContext)
            {
                  _appContext = appContext;
            }

            IEnumerable<Administrativo> IRepoAdministrativo.GetAllAdministrativos()
            {
                  return _appContext.Administrativos;
            }

            Administrativo IRepoAdministrativo.AddAdministrativo(Administrativo administrativo)
            {
                  var administrativoAdicionado = _appContext.Administrativos.Add(administrativo);
                  _appContext.SaveChanges();
                  return administrativoAdicionado.Entity;
            }
            Administrativo IRepoAdministrativo.GetAdministrativo(int idAdministrativo)
            {
                  return _appContext.Administrativos.FirstOrDefault(p => p.Id == idAdministrativo);
            }

            Administrativo IRepoAdministrativo.UpdateAdministrativo(Administrativo administrativo)
            {
                  var administrativoEncontrado = _appContext.Administrativos.FirstOrDefault(p => p.Id == administrativo.Id);
                  if (administrativoEncontrado != null)
                  {
                        administrativoEncontrado.Identificacion = administrativo.Identificacion;
                        administrativoEncontrado.Nombres = administrativo.Nombres;
                        administrativoEncontrado.Apellidos = administrativo.Apellidos;
                        administrativoEncontrado.Edad = administrativo.Edad;
                        administrativoEncontrado.Genero = administrativo.Genero;
                        administrativoEncontrado.Diagnosticos = administrativo.Diagnosticos;
                        administrativoEncontrado.Rol = administrativo.Rol;

                        _appContext.SaveChanges();
                  }

                  return administrativoEncontrado;
            }

            void IRepoAdministrativo.DeleteAdministrativo(int idAdministrativo)
            {
                  var administrativoEncontrado = _appContext.Administrativos.FirstOrDefault(p => p.Id == idAdministrativo);
                  if (administrativoEncontrado == null)
                        return;
                  _appContext.Administrativos.Remove(administrativoEncontrado);
                  _appContext.SaveChanges();
            }
      }
}