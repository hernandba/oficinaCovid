using System;
using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
      public class RepoSecretario : IRepoSecretario
      {
            private readonly AppContext _appContext;

            public RepoSecretario(AppContext appContext)
            {
                  _appContext = appContext;
            }

            IEnumerable<Secretario> IRepoSecretario.GetAllSecretarios()
            {
                  return _appContext.Secretarios;
            }

            Secretario IRepoSecretario.AddSecretario(Secretario secretario)
            {
                  var secretarioAdicionado = _appContext.Secretarios.Add(secretario);
                  _appContext.SaveChanges();
                  return secretarioAdicionado.Entity;
            }
            Secretario IRepoSecretario.GetSecretario(int idSecretario)
            {
                  return _appContext.Secretarios.FirstOrDefault(p => p.Id == idSecretario);
            }

            Secretario IRepoSecretario.UpdateSecretario(Secretario secretario)
            {
                  var secretarioEncontrado = _appContext.Secretarios.FirstOrDefault(p => p.Id == secretario.Id);
                  if (secretarioEncontrado != null)
                  {
                        secretarioEncontrado.Identificacion = secretario.Identificacion;
                        secretarioEncontrado.Nombres = secretario.Nombres;
                        secretarioEncontrado.Apellidos = secretario.Apellidos;
                        secretarioEncontrado.Edad = secretario.Edad;
                        secretarioEncontrado.Genero = secretario.Genero;
                        secretarioEncontrado.Diagnosticos = secretario.Diagnosticos;

                        _appContext.SaveChanges();
                  }

                  return secretarioEncontrado;
            }

            void IRepoSecretario.DeleteSecretario(int idSecretario)
            {
                  var secretarioEncontrado = _appContext.Secretarios.FirstOrDefault(p => p.Id == idSecretario);
                  if (secretarioEncontrado == null)
                        return;
                  _appContext.Secretarios.Remove(secretarioEncontrado);
                  _appContext.SaveChanges();
            }
      }
}