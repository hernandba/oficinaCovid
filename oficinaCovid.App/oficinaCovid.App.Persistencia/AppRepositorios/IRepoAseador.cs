using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace  oficinaCovid.App.Persistencia
{
    //Las interfaces contienen "las firmas" de todos los metodos que se van a implementar
    public interface IRepoAseador
    {
        IEnumerable<Aseador> GetAllAseadores();
        Aseador AddAseador(Aseador aseador);
        Aseador GetAseador(int idAseador);
        Aseador UpdateAseador(Aseador aseador);
        void DeleteAseador(int idAseador);
    }
}