using System;
using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class RepositorioOficina : IRepositorioOficina
    {
        private readonly AppContext _appContext;

        public RepositorioOficina(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Oficina> IRepositorioOficina.GetAll()
        {
            return _appContext.oficinas;
        }

        IEnumerable<Oficina> IRepositorioOficina.GetOficinasGobernacion(Gobernacion gobernacion)
        {
            return _appContext.oficinas.Where(x => x.gobernacion == gobernacion);
        }

        Oficina IRepositorioOficina.GetOficina(int oficinaId)
        {
            var oficinaEncontrada = _appContext.oficinas.FirstOrDefault(x => x.id == oficinaId);
            return oficinaEncontrada;
        }

        Oficina IRepositorioOficina.AddOficina(Oficina oficina)
        {
            var oficinaAgregada = _appContext.oficinas.Add(oficina);
            _appContext.SaveChanges();
            return oficinaAgregada.Entity;
        }

        Oficina IRepositorioOficina.UpdateOficina(Oficina oficina, Gobernacion gobernacion, SecretarioDespacho secretario)
        {
            var oficinaEncontrada = _appContext.oficinas.FirstOrDefault(x => x.id == oficina.id);
            if (oficinaEncontrada != null)
            {
                oficinaEncontrada.numero = oficina.numero;
                oficinaEncontrada.gobernacion = gobernacion;
                oficinaEncontrada.secretario = secretario;
                oficinaEncontrada.aforo = oficina.aforo;
                _appContext.SaveChanges();
            }
            return oficina;
        }

        bool IRepositorioOficina.DeleteOficina(int oficinaId)
        {
             var oficinaEncontrada = _appContext.oficinas.FirstOrDefault(x => x.id == oficinaId);
            if (oficinaEncontrada == null)
                return false;
            _appContext.oficinas.Remove(oficinaEncontrada);
            _appContext.SaveChanges();
            return true;
        }
    }
}