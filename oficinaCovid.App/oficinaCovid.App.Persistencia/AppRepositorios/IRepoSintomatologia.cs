using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace  oficinaCovid.App.Persistencia
{
    //Las interfaces contienen "las firmas" de todos los metodos que se van a implementar
    public interface IRepoSintomatologia
    {
        IEnumerable<Sintomatologia> GetAllSintomatologias();
        Sintomatologia AddSintomatologia(Sintomatologia sintomatologia);
        Sintomatologia GetSintomatologia(int idSintomatologia);
        Sintomatologia UpdateSintomatologia(Sintomatologia sintomatologia);
        void DeleteSintomatologia(int idSintomatologia);
    }
}