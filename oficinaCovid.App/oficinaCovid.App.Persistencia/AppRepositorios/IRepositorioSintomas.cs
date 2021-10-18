using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioSintomas
    {
        IEnumerable<SintomasCovid> GetAll();
        SintomasCovid GetSintomas(int sintomasId);
        SintomasCovid GetSintomasInDiagnostico(int diagnosticoID);
        SintomasCovid AddSintomas(SintomasCovid sintomas);
        SintomasCovid UpdateSintomas(SintomasCovid sintomas);
        bool DeleteSintomas(int sintomasId);
    }
}