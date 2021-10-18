using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class RepositorioProveedor : IRepositorioProveedor
    {
        private readonly AppContext _appContext;

        public RepositorioProveedor(AppContext appContext)
        {
            _appContext = appContext;
        }

        // CRUD
        // Obtiene todos los gobernadores / Asesores
        IEnumerable<PersonalProveedor> IRepositorioProveedor.GetAll()
        {
            return _appContext.personalProveedor;
        }
        // Obtiene solo uno
        PersonalProveedor IRepositorioProveedor.GetProveedor(int idProveedor)
        {
            var proveedorEncontrado = _appContext.personalProveedor.FirstOrDefault(x => x.id == idProveedor);
            return proveedorEncontrado;
        }

        // Guardar en la base de datos
        PersonalProveedor IRepositorioProveedor.AddProveedor(PersonalProveedor proveedor)
        {
            var proveedorAgregado = _appContext.personalProveedor.Add(proveedor);
            _appContext.SaveChanges();
            return proveedorAgregado.Entity;
        }
        // Actualizar
        PersonalProveedor IRepositorioProveedor.UpdateProveedor(PersonalProveedor proveedor)
        {
            var proveedorEncontrado = _appContext.personalProveedor.SingleOrDefault(x => x.id == proveedor.id);
            if (proveedorEncontrado != null)
            {   
                proveedorEncontrado.identificacion = proveedor.identificacion;
                proveedorEncontrado.nombres = proveedor.nombres;
                proveedorEncontrado.apellidos = proveedor.apellidos;
                proveedorEncontrado.edad = proveedor.edad;
                proveedorEncontrado.genero = proveedor.genero;
                proveedorEncontrado.servicioRealizado = proveedor.servicioRealizado;
                proveedorEncontrado.nombreEmpresa = proveedor.nombreEmpresa;

                _appContext.SaveChanges();   
            }
            return proveedorEncontrado;
        }
        // ELiminar
        bool IRepositorioProveedor.DeleteProveedor(int idProveedor)
        {
            var proveedorEncontrado = _appContext.personalProveedor.FirstOrDefault(x => x.id == idProveedor);
            if (proveedorEncontrado == null)
                return false;
            _appContext.personalProveedor.Remove(proveedorEncontrado);
            _appContext.SaveChanges();
            return true;
        }
    }
}