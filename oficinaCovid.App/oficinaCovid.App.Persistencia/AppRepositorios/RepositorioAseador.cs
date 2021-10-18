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

        IEnumerable<PersonalAseo> IRepositorioAseador.GetAllPersonalAseo(int gobernacionid)
        {   
            IEnumerable<PersonalAseo> aseadoreEncontrados = (from a in _appContext.aseadores
                                    join g in _appContext.gobernaciones on a.gobernacion equals g
                                    where g.id == gobernacionid
                                    select new PersonalAseo{
                                        id = a.id,
                                        identificacion = a.identificacion,
                                        nombres = a.nombres,
                                        apellidos = a.apellidos,
                                        edad = a.edad,
                                        genero = a.genero,
                                        horaIngreso = a.horaIngreso,
                                        horaSalida = a.horaSalida,
                                        gobernacion = a.gobernacion
                                    });
            return aseadoreEncontrados;
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

        PersonalAseo IRepositorioAseador.UpdateAseador(PersonalAseo aseador, int gobernacionid)
        {
            var aseadorEncontrado = _appContext.aseadores.SingleOrDefault(x => x.id == aseador.id);
            Gobernacion gobernacion = _appContext.gobernaciones.FirstOrDefault(x => x.id == gobernacionid);
            if (aseadorEncontrado != null)
            {   
                aseadorEncontrado.identificacion = aseador.identificacion;
                aseadorEncontrado.nombres = aseador.nombres;
                aseadorEncontrado.apellidos = aseador.apellidos;
                aseadorEncontrado.edad = aseador.edad;
                aseadorEncontrado.horaIngreso = aseador.horaIngreso;
                aseadorEncontrado.horaSalida = aseador.horaSalida;
                aseadorEncontrado.gobernacion = gobernacion;
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