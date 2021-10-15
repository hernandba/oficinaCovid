using System;
using System.Collections.Generic;
using System.Linq;
using visitaCovid.App.Dominio;

namespace visitaCovid.App.Persistencia
{
      public class RepoVisita : IRepoVisita
      {
            private readonly AppContext _appContext;

            public RepoVisita(AppContext appContext)
            {
                  _appContext = appContext;
            }

            IEnumerable<Visita> IRepoVisita.GetAllVisitas()
            {
                  return _appContext.Visitas;
            }

            Visita IRepoVisita.AddVisita(Visita visita)
            {
                  var visitaAdicionado = _appContext.Visitas.Add(visita);
                  _appContext.SaveChanges();
                  return visitaAdicionado.Entity;
            }
            Visita IRepoVisita.GetVisita(int idVisita)
            {
                  return _appContext.Visitas.FirstOrDefault(p => p.Id == idVisita);
            }

            Visita IRepoVisita.UpdateVisita(Visita visita)
            {
                  var visitaEncontrado = _appContext.Visitas.FirstOrDefault(p => p.Id == visita.Id);
                  if (visitaEncontrado != null)
                  {
                        visitaEncontrado.Fecha = visita.Fecha;
                        visitaEncontrado.HoraIngreso = visita.HoraIngreso;
                        visitaEncontrado.HoraSalida = visita.HoraSalida;
                        visitaEncontrado.Persona = visita.Persona;
                        visitaEncontrado.Oficina = visita.Oficina;

                        _appContext.SaveChanges();
                  }

                  return visitaEncontrado;
            }

            void IRepoVisita.DeleteVisita(int idVisita)
            {
                  var visitaEncontrado = _appContext.Visitas.FirstOrDefault(p => p.Id == idVisita);
                  if (visitaEncontrado == null)
                        return;
                  _appContext.Visitas.Remove(visitaEncontrado);
                  _appContext.SaveChanges();
            }
      }
}