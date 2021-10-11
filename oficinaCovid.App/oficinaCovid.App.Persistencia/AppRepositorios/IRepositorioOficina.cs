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
        Oficina UpdateOficina(Oficina oficina, Gobernacion gobernacion, SecretarioDespacho secretario);
        bool DeleteOficina(int oficinaId);
    }
}