using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioDiagnostico
    {
        IEnumerable<Diagnostico> GetAll();
        IEnumerable<Diagnostico> GetDiagnosticosInPersona(int personaID);
        Diagnostico GetDiagnostico(int diagnosticoId);
        Diagnostico AddDiagnostico(Diagnostico diagnostico);
        Diagnostico UpdateDiagnostico(Diagnostico diagnostico, int personaID, int sintomasID);
        bool DeleteDiagnostico(int diagnosticoId);
    }
}