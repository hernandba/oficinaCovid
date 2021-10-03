using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioGobernacion
    {
        IEnumerable<Gobernacion> GetAll();
        Gobernacion GetGobernacion(int gobernacionId);
        Gobernacion AddGobernacion(Gobernacion gobernacion);
        Gobernacion UpdateGobernacion(Gobernacion gobernacion);
        bool DeleteGobernacion(int gobernacionId);
    }
}