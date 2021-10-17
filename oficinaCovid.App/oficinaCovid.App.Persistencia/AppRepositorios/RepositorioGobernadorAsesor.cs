using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class RepositorioGobernadorAsesor : IRepositorioGobernadorAsesor
    {
        private readonly AppContext _appContext;

        public RepositorioGobernadorAsesor(AppContext appContext)
        {
            _appContext = appContext;
        }

        // CRUD
        // Obtiene todos los gobernadores / Asesores
        IEnumerable<GobernadorAsesor> IRepositorioGobernadorAsesor.GetAll(int gobernacionid)
        {
            IEnumerable<GobernadorAsesor> gobernadores = (from gb in _appContext.gobernadores
                                                          join g in _appContext.gobernaciones on gb.gobernacion equals g
                                                          where g.id == gobernacionid
                                                          select new GobernadorAsesor{
                                                                id = gb.id,
                                                                identificacion = gb.identificacion,
                                                                nombres = gb.nombres,
                                                                apellidos = gb.apellidos,
                                                                edad = gb.edad,
                                                                genero = gb.genero,
                                                                rol = gb.rol,
                                                                gobernacion = gb.gobernacion
                                                          });
            return gobernadores;
        }

        // Obtiene a todos dependiendo del rol
        IEnumerable<GobernadorAsesor> IRepositorioGobernadorAsesor.GetAllGobAse(string rol)
        {
            return _appContext.gobernadores;
        }

        // Obtiene solo uno
        GobernadorAsesor IRepositorioGobernadorAsesor.GetGA(int idGobAse)
        {
            var gobernadorEncontrado = _appContext.gobernadores.FirstOrDefault(g => g.id == idGobAse);
            return gobernadorEncontrado;
        }

        // Guardar en la base de datos
        GobernadorAsesor IRepositorioGobernadorAsesor.AddGA(GobernadorAsesor gobernadorAsesor)
        {
            var gobAseAdicionado = _appContext.gobernadores.Add(gobernadorAsesor);
            _appContext.SaveChanges();
            return gobAseAdicionado.Entity;
        }
        // Actualizar
        GobernadorAsesor IRepositorioGobernadorAsesor.UpdateGA(GobernadorAsesor gobernadorAsesor, int gobernacionID)
        {   
            Gobernacion gobernacion = _appContext.gobernaciones.FirstOrDefault(x => x.id == gobernacionID);
            var gobernadorEncontrado = _appContext.gobernadores.SingleOrDefault(g => g.id == gobernadorAsesor.id);
            if (gobernadorEncontrado != null)
            {   
                gobernadorEncontrado.identificacion = gobernadorAsesor.identificacion;
                gobernadorEncontrado.nombres = gobernadorAsesor.nombres;
                gobernadorEncontrado.apellidos = gobernadorAsesor.apellidos;
                gobernadorEncontrado.edad = gobernadorAsesor.edad;
                gobernadorEncontrado.genero = gobernadorAsesor.genero;
                gobernadorEncontrado.rol = gobernadorAsesor.rol;
                gobernadorEncontrado.gobernacion = gobernacion;

                _appContext.SaveChanges();   
            }
            return gobernadorEncontrado;
        }
        // ELiminar
        bool IRepositorioGobernadorAsesor.DeleteGA(int idGobernadorAsesor)
        {
            var gobernadorEncontrado = _appContext.gobernadores.FirstOrDefault(g => g.id == idGobernadorAsesor);
            if (gobernadorEncontrado == null)
                return false;
            _appContext.gobernadores.Remove(gobernadorEncontrado);
            _appContext.SaveChanges();
            return true;
        }
    }
}