using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioOficina
    {
        IEnumerable<Oficina> GetAll();
        Oficina GetOficina(int oficinaId);
        Oficina AddOficina(Oficina oficina);
        Oficina UpdateOficina(Oficina oficina, Gobernacion gobernacion, SecretarioDespacho secretario);
        bool DeleteOficina(int oficinaId);
    }
}