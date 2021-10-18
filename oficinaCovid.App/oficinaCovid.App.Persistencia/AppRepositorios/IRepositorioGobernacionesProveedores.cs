using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRespositorioGobernacionesProveedores
    {
        IEnumerable<PersonalProveedor> GetProveedoresInGobernacion(int gobernacionID);
        IEnumerable<PersonalProveedor> GetProveedoresNotInGobernacion(int gobernacionID);
        GobernacionProveedor AddProveedorInGobernacion(GobernacionProveedor gobernacionProveedor);
        GobernacionProveedor UpdateProveedorInGobernacion(int gobernacionID, int proveedorID);
        bool DeleteProveedorInGobernacion(int proveedorID, int gobernacionID);

    }
}