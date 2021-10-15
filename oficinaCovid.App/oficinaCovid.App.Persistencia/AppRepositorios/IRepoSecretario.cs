using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace  oficinaCovid.App.Persistencia
{
    //Las interfaces contienen "las firmas" de todos los metodos que se van a implementar
    public interface IRepoSecretario
    {
        IEnumerable<Secretario> GetAllSecretarios();
        Secretario AddSecretario(Secretario secretario);
        Secretario GetSecretario(int idSecretario);
        Secretario UpdateSecretario(Secretario secretario);
        void DeleteSecretario(int idSecretario);
    }
}