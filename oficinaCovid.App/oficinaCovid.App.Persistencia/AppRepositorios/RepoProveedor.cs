using System;
using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
      public class RepoProveedor : IRepoProveedor
      {
            private readonly AppContext _appContext;

            public RepoProveedor(AppContext appContext)
            {
                  _appContext = appContext;
            }

            IEnumerable<Proveedor> IRepoProveedor.GetAllProveedores()
            {
                  return _appContext.Proveedores;
            }

            Proveedor IRepoProveedor.AddProveedor(Proveedor proveedor)
            {
                  var proveedorAdicionado = _appContext.Proveedores.Add(proveedor);
                  _appContext.SaveChanges();
                  return proveedorAdicionado.Entity;
            }
            Proveedor IRepoProveedor.GetProveedor(int idProveedor)
            {
                  return _appContext.Proveedores.FirstOrDefault(p => p.Id == idProveedor);
            }

            Proveedor IRepoProveedor.UpdateProveedor(Proveedor proveedor)
            {
                  var proveedorEncontrado = _appContext.Proveedores.FirstOrDefault(p => p.Id == proveedor.Id);
                  if (proveedorEncontrado != null)
                  {
                        proveedorEncontrado.Identificacion = proveedor.Identificacion;
                        proveedorEncontrado.Nombres = proveedor.Nombres;
                        proveedorEncontrado.Apellidos = proveedor.Apellidos;
                        proveedorEncontrado.Edad = proveedor.Edad;
                        proveedorEncontrado.Genero = proveedor.Genero;
                        proveedorEncontrado.Diagnosticos = proveedor.Diagnosticos;
                        proveedorEncontrado.Servicio = proveedor.Servicio;

                        _appContext.SaveChanges();
                  }

                  return proveedorEncontrado;
            }

            void IRepoProveedor.DeleteProveedor(int idProveedor)
            {
                  var proveedorEncontrado = _appContext.Proveedores.FirstOrDefault(p => p.Id == idProveedor);
                  if (proveedorEncontrado == null)
                        return;
                  _appContext.Proveedores.Remove(proveedorEncontrado);
                  _appContext.SaveChanges();
            }
      }
}