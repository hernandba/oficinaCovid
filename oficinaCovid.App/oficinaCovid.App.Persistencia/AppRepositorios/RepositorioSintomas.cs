using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class RepositorioSintomas : IRepositorioSintomas
    {
        private readonly AppContext _appContext;

        public RepositorioSintomas(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<SintomasCovid> IRepositorioSintomas.GetAll()
        {
            return _appContext.sintomas;
        }

        SintomasCovid IRepositorioSintomas.GetSintomas(int sintomasId)
        {
            var sintomasEncontrado = _appContext.sintomas.FirstOrDefault(x => x.id == sintomasId);
            return sintomasEncontrado;
        }

        SintomasCovid IRepositorioSintomas.AddSintomas(SintomasCovid sintomas)
        {
            var sintomasAgregado = _appContext.sintomas.Add(sintomas);
            _appContext.SaveChanges();
            return sintomasAgregado.Entity;
        }

        SintomasCovid IRepositorioSintomas.UpdateSintomas(SintomasCovid sintomas)
        {
            var sintomasEncontrado = _appContext.sintomas.FirstOrDefault(x => x.id == sintomas.id);
            if (sintomasEncontrado != null)
            {
                sintomasEncontrado.fiebre = sintomas.fiebre;
                sintomasEncontrado.perdidaOlfato = sintomas.perdidaOlfato;
                sintomasEncontrado.perdidaGusto = sintomas.perdidaGusto;
                sintomasEncontrado.tosSeca = sintomas.tosSeca;
                sintomasEncontrado.desaliento = sintomas.desaliento;
                sintomasEncontrado.dolorGarganta = sintomas.dolorGarganta;
                sintomasEncontrado.dificultadRespirar = sintomas.dificultadRespirar;
                _appContext.SaveChanges();
            }
            return sintomas;
        }

        bool IRepositorioSintomas.DeleteSintomas(int sintomasId)
        {
             var sintomasEncontrado = _appContext.sintomas.FirstOrDefault(x => x.id == sintomasId);
            if (sintomasEncontrado == null)
                return false;
            _appContext.sintomas.Remove(sintomasEncontrado);
            _appContext.SaveChanges();
            return true;
        }
    }
}