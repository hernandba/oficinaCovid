using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace  oficinaCovid.App.Persistencia
{
    //Las interfaces contienen "las firmas" de todos los metodos que se van a implementar
    public interface IRepoGobernacion
    {
        IEnumerable<Gobernacion> GetAllGobernaciones();
        Gobernacion AddGobernacion(Gobernacion gobernacion);
        Gobernacion GetGobernacion(int idGobernacion);
        Gobernacion UpdateGobernacion(Gobernacion gobernacion);
        void DeleteGobernacion(int idGobernacion);
    }
}