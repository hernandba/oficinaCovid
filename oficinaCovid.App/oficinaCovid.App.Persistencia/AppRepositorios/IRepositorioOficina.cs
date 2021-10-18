using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioOficina
    {
        IEnumerable<Oficina> GetAll();
        IEnumerable<Oficina> GetOficinasGobernacion(Gobernacion gobernacion);
        Oficina GetOficina(int oficinaId);
        Oficina AddOficina(Oficina oficina, Gobernacion gobernacion);
        Oficina UpdateOficina(Oficina oficina, int gobernacionid, int secretarioid);
        bool DeleteOficina(int oficinaId);
    }
}