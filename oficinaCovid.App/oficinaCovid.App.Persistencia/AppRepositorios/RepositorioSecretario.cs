using System.Collections.Generic;
using System.Linq;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class RepositorioSecretario : IRepositorioSecretario
    {
        private readonly AppContext _appContext;

        public RepositorioSecretario(AppContext appContext)
        {
            _appContext = appContext;
        }

        // CRUD
        // Obtiene todos los secretarios
        IEnumerable<SecretarioDespacho> IRepositorioSecretario.GetAll()
        {
            return _appContext.secretarios;
        }

        // Obtiene solo uno
        SecretarioDespacho IRepositorioSecretario.GetSecretario(int idSecretario)
        {
            var secretarioEncontrado = _appContext.secretarios.FirstOrDefault(s => s.id == idSecretario);
            return secretarioEncontrado;
        }

        // Guardar en la base de datos
        SecretarioDespacho IRepositorioSecretario.AddSecretario(SecretarioDespacho secretario)
        {
            var secretarioAdicionado = _appContext.secretarios.Add(secretario);
            _appContext.SaveChanges();
            return secretarioAdicionado.Entity;
        }
        // Actualizar
        SecretarioDespacho IRepositorioSecretario.UpdateSecretario(SecretarioDespacho secretario)
        {
            var secretarioEncontrado = _appContext.secretarios.SingleOrDefault(s => s.id == secretario.id);
            if (secretarioEncontrado != null)
            {   
                secretarioEncontrado.identificacion = secretario.identificacion;
                secretarioEncontrado.nombres = secretario.nombres;
                secretarioEncontrado.apellidos = secretario.apellidos;
                secretarioEncontrado.edad = secretario.edad;
                secretarioEncontrado.genero = secretario.genero;

                _appContext.SaveChanges();   
            }
            return secretarioEncontrado;
        }
        // ELiminar
        bool IRepositorioSecretario.DeleteSecretario(int idSecretario)
        {
            var secretarioEncontrado = _appContext.secretarios.FirstOrDefault(s => s.id == idSecretario);
            if (secretarioEncontrado == null)
                return false;
            _appContext.secretarios.Remove(secretarioEncontrado);
            _appContext.SaveChanges();
            return true;
        }
    }    
}