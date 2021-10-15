using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace  oficinaCovid.App.Persistencia
{
    //Las interfaces contienen "las firmas" de todos los metodos que se van a implementar
    public interface IRepoOficina
    {
        IEnumerable<Oficina> GetAllOficinas();
        Oficina AddOficina(Oficina oficina);
        Oficina GetOficina(int idOficina);
        Oficina UpdateOficina(Oficina oficina);
        void DeleteOficina(int idOficina);
    }
}