using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioProveedor
    {
        // CRUD
        // Obtiene todos los gobernadores / Asesores
        IEnumerable<PersonalProveedor> GetAll();
        // Obtiene solo uno
        PersonalProveedor GetProveedor(int idProveedor);
        // Guardar en la base de datos
        PersonalProveedor AddProveedor(PersonalProveedor proveedor);
        // Actualizar
        PersonalProveedor UpdateProveedor(PersonalProveedor proveedor);
        // ELiminar
        bool DeleteProveedor(int idProveedor);
    }
}