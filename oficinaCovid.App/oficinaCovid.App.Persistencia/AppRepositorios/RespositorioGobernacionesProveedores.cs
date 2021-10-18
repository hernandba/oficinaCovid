using System.Collections.Generic;
using System.Linq;
using System;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class RespositorioGobernacionesProveedores : IRespositorioGobernacionesProveedores
    {
        private readonly AppContext _appContext;

        public RespositorioGobernacionesProveedores(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<PersonalProveedor> IRespositorioGobernacionesProveedores.GetProveedoresInGobernacion(int gobernacionID)
        {   
            Gobernacion gobernacion = _appContext.gobernaciones.FirstOrDefault(x => x.id == gobernacionID);
            IEnumerable<PersonalProveedor> proveedores = (from p in _appContext.personalProveedor
                                                          join pg in _appContext.proveedoresGobernacion on p equals pg.proveedor
                                                          join g in _appContext.gobernaciones on pg.gobernacion equals g
                                                          where pg.gobernacion == gobernacion
                                                          select new PersonalProveedor{
                                                            id = p.id,
                                                            identificacion = p.identificacion,
                                                            nombres = p.nombres,
                                                            apellidos = p.apellidos,
                                                            edad = p.edad,
                                                            genero = p.genero,
                                                            nombreEmpresa = p.nombreEmpresa,
                                                            servicioRealizado = p.servicioRealizado                                                            
                                                          });

            return proveedores;
        }
        
        IEnumerable<PersonalProveedor> IRespositorioGobernacionesProveedores.GetProveedoresNotInGobernacion(int gobernacionID)
        {   
            Gobernacion gobernacion = _appContext.gobernaciones.FirstOrDefault(x => x.id == gobernacionID);
            IEnumerable<PersonalProveedor> proveedores = (from p in _appContext.personalProveedor
                                                          join pg in _appContext.proveedoresGobernacion on p equals pg.proveedor into pgo
                                                          from pg in pgo.DefaultIfEmpty()
                                                          where pg.gobernacion != gobernacion && pg.proveedor == null
                                                          select new PersonalProveedor{
                                                            id = p.id,
                                                            identificacion = p.identificacion,
                                                            nombres = p.nombres,
                                                            apellidos = p.apellidos,
                                                            edad = p.edad,
                                                            genero = p.genero,
                                                            nombreEmpresa = p.nombreEmpresa,
                                                            servicioRealizado = p.servicioRealizado                                                            
                                                          });

            return proveedores;
        }

        GobernacionProveedor IRespositorioGobernacionesProveedores.AddProveedorInGobernacion(GobernacionProveedor gobernacionProveedor)
        {
            var gobernacionProveedorAgg = _appContext.proveedoresGobernacion.Add(gobernacionProveedor);
            _appContext.SaveChanges();
            return gobernacionProveedorAgg.Entity;
        }

        GobernacionProveedor IRespositorioGobernacionesProveedores.UpdateProveedorInGobernacion(int gobernacionID, int proveedorID)
        {
            Gobernacion gobernacion = _appContext.gobernaciones.FirstOrDefault(x => x.id == gobernacionID);
            PersonalProveedor proveedor = _appContext.personalProveedor.FirstOrDefault(x => x.id == proveedorID);
            GobernacionProveedor gpEncontrado = _appContext.proveedoresGobernacion.FirstOrDefault(x => x.proveedorId == proveedorID && x.gobernacionId == gobernacionID);
            
            if (gpEncontrado != null)
            {
                gpEncontrado.proveedorId = proveedor.id;
                gpEncontrado.gobernacionId= gobernacion.id;
                gpEncontrado.proveedor = proveedor;
                gpEncontrado.gobernacion = gobernacion;
                
                _appContext.SaveChanges();
            }
            return gpEncontrado;
        }

        bool IRespositorioGobernacionesProveedores.DeleteProveedorInGobernacion(int proveedorID, int gobernacionID)
        {
            GobernacionProveedor gproveedores = _appContext.proveedoresGobernacion.FirstOrDefault(x => x.proveedorId == proveedorID && x.gobernacionId == gobernacionID);
            //Console.WriteLine("ID gobernacion: " + gproveedores.gobernacionId + "\nID proveedor: " + gproveedores.proveedorId);
            _appContext.proveedoresGobernacion.Remove(gproveedores);
            _appContext.SaveChanges();
            return true;
        }
    }
}