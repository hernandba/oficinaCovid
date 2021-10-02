using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class RepositorioAseador : IRepositorioAseador
    {
        private readonly AppContext _appContext;

        public RepositorioAseador(AppContext appContext)
        {
            _appContext = appContext;
        }

        // CRUD

        IEnumerable<PersonalAseo> IRepositorioAseador.GetAllPersonalAseo()
        {
            return _appContext.aseadores;
        }

        PersonalAseo IRepositorioAseador.GetAseador(int aseadorId)
        {
            var aseador = _appContext.aseadores.FirstOrDefault(x => x.id == aseadorId);
            return aseador;
        }

        PersonalAseo IRepositorioAseador.AddAseador(PersonalAseo aseadorNuevo)
        {
            var aseadorAgregado = _appContext.aseadores.Add(aseadorNuevo);
            _appContext.SaveChanges();
            return aseadorAgregado.Entity;
        }

        PersonalAseo IRepositorioAseador.UpdateAseador(PersonalAseo aseador)
        {
            var aseadorEncontrado = _appContext.aseadores.SingleOrDefault(x => x.id == aseador.id);
            if (aseadorEncontrado != null)
            {
                aseadorEncontrado.nombres = aseador.nombres;
                aseadorEncontrado.apellidos = aseador.apellidos;

                _appContext.SaveChanges();
            }

            return aseador;
        }

        bool IRepositorioAseador.DeleteAseador(int aseadorId)
        {
            var aseadorEncontrado = _appContext.aseadores.SingleOrDefault(x => x.id == aseadorId);
            if (aseadorEncontrado == null)
                return false;
            _appContext.aseadores.Remove(aseadorEncontrado);
            _appContext.SaveChanges();
            return true;
        }
    }
}