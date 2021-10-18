using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class RepositorioGobernacion : IRepositorioGobernacion
    {
        private readonly AppContext _appContext;

        public RepositorioGobernacion(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Gobernacion> IRepositorioGobernacion.GetAll()
        {
            return _appContext.gobernaciones;
        }

        Gobernacion IRepositorioGobernacion.GetGobernacion(int gobernacionId)
        {
            var gobernacionEncontrada = _appContext.gobernaciones.FirstOrDefault(x => x.id == gobernacionId);
            return gobernacionEncontrada;
        }

        Gobernacion IRepositorioGobernacion.AddGobernacion(Gobernacion gobernacion)
        {
            var gobernacionAgregada = _appContext.gobernaciones.Add(gobernacion);
            _appContext.SaveChanges();
            return gobernacionAgregada.Entity;
        }

        Gobernacion IRepositorioGobernacion.UpdateGobernacion(Gobernacion gobernacion)
        {
            var gobernacionEncontrada = _appContext.gobernaciones.FirstOrDefault(x => x.id == gobernacion.id);
            if (gobernacionEncontrada != null)
            {   
                gobernacionEncontrada.nombre = gobernacion.nombre;
                gobernacionEncontrada.ciudad = gobernacion.ciudad;
                gobernacionEncontrada.direccion = gobernacion.direccion;
                gobernacionEncontrada.numeroOficinas = gobernacion.numeroOficinas;
                _appContext.SaveChanges();
            }

            return gobernacion;
        }

        bool IRepositorioGobernacion.DeleteGobernacion(int gobernacionId)
        {
            var gobernacionEncontrada = _appContext.gobernaciones.FirstOrDefault(x => x.id == gobernacionId);
            if (gobernacionEncontrada == null)
                return false;
            _appContext.gobernaciones.Remove(gobernacionEncontrada);
            _appContext.SaveChanges();
            return true;
        }
    }
}