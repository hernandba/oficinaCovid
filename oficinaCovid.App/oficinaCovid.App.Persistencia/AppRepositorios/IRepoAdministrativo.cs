using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace  oficinaCovid.App.Persistencia
{
    //Las interfaces contienen "las firmas" de todos los metodos que se van a implementar
    public interface IRepoAdministrativo
    {
        IEnumerable<Administrativo> GetAllAdministrativos();
        Administrativo AddAdministrativo(Administrativo administrativo);
        Administrativo GetAdministrativo(int idAdministrativo);
        Administrativo UpdateAdministrativo(Administrativo administrativo);
        void DeleteAdministrativo(int idAdministrativo);
    }
}