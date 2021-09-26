using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioSecretario
    {
        // CRUD
        // Obtiene todos los secretarios/as
        IEnumerable<SecretarioDespacho> GetAll();
        // Obtiene solo uno
        SecretarioDespacho GetSecretario(int idSecretario);
        // Guardar en la base de datos
        SecretarioDespacho AddSecretario(SecretarioDespacho secretario);
        // Actualizar
        SecretarioDespacho UpdateSecretario(SecretarioDespacho secretario);
        // ELiminar
        bool DeleteSecretario(int idSecretario);   
    }
}