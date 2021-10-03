using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioDiagnostico
    {
        IEnumerable<Diagnostico> GetAll();
        Diagnostico GetDiagnostico(int diagnosticoId);
        Diagnostico AddDiagnostico(Diagnostico diagnostico);
        Diagnostico UpdateDiagnostico(Diagnostico diagnostico);
        bool DeleteDiagnostico(int diagnosticoId);
    }
}