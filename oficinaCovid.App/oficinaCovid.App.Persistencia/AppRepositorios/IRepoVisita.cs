using System.Collections.Generic;
using visitaCovid.App.Dominio;

namespace  visitaCovid.App.Persistencia
{
    //Las interfaces contienen "las firmas" de todos los metodos que se van a implementar
    public interface IRepoVisita
    {
        IEnumerable<Visita> GetAllVisitas();
        Visita AddVisita(Visita visita);
        Visita GetVisita(int idVisita);
        Visita UpdateVisita(Visita visita);
        void DeleteVisita(int idVisita);
    }
}