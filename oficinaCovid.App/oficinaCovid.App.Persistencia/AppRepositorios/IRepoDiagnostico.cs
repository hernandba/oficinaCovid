using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace  oficinaCovid.App.Persistencia
{
    //Las interfaces contienen "las firmas" de todos los metodos que se van a implementar
    public interface IRepoDiagnostico
    {
        IEnumerable<Diagnostico> GetAllDiagnosticos();
        Diagnostico AddDiagnostico(Diagnostico diagnostico);
        Diagnostico GetDiagnostico(int idDiagnostico);
        Diagnostico UpdateDiagnostico(Diagnostico diagnostico);
        void DeleteDiagnostico(int idDiagnostico);
    }
}