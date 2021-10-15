using System;
using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
      public class RepoGobernacion : IRepoGobernacion
      {
            private readonly AppContext _appContext;

            public RepoGobernacion(AppContext appContext)
            {
                  _appContext = appContext;
            }

            IEnumerable<Gobernacion> IRepoGobernacion.GetAllGobernaciones()
            {
                  return _appContext.Gobernaciones;
            }

            Gobernacion IRepoGobernacion.AddGobernacion(Gobernacion gobernacion)
            {
                  var gobernacionAdicionado = _appContext.Gobernaciones.Add(gobernacion);
                  _appContext.SaveChanges();
                  return gobernacionAdicionado.Entity;
            }
            Gobernacion IRepoGobernacion.GetGobernacion(int idGobernacion)
            {
                  return _appContext.Gobernaciones.FirstOrDefault(p => p.Id == idGobernacion);
            }

            Gobernacion IRepoGobernacion.UpdateGobernacion(Gobernacion gobernacion)
            {
                  var gobernacionEncontrado = _appContext.Gobernaciones.FirstOrDefault(p => p.Id == gobernacion.Id);
                  if (gobernacionEncontrado != null)
                  {
                        gobernacionEncontrado.Direccion = gobernacion.Direccion;
                        gobernacionEncontrado.NumeroOficinas = gobernacion.NumeroOficinas;
                        gobernacionEncontrado.Administrativos = gobernacion.Administrativos;
                        gobernacionEncontrado.Aseadores = gobernacion.Aseadores;
                        gobernacionEncontrado.Proveedores = gobernacion.Proveedores;
                        gobernacionEncontrado.Secretarios = gobernacion.Secretarios;
                        gobernacionEncontrado.Oficinas = gobernacion.Oficinas;

                        _appContext.SaveChanges();
                  }

                  return gobernacionEncontrado;
            }

            void IRepoGobernacion.DeleteGobernacion(int idGobernacion)
            {
                  var gobernacionEncontrado = _appContext.Gobernaciones.FirstOrDefault(p => p.Id == idGobernacion);
                  if (gobernacionEncontrado == null)
                        return;
                  _appContext.Gobernaciones.Remove(gobernacionEncontrado);
                  _appContext.SaveChanges();
            }
      }
}