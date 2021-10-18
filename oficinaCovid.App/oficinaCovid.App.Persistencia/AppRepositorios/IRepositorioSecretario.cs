using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioSecretario
    {
        // CRUD
        // Obtiene todos los secretarios/as
        IEnumerable<SecretarioDespacho> GetAll(Gobernacion gobernacion);

        IEnumerable<SecretarioDespacho> GetAllSecretarioGobernacion(Gobernacion gobernacion);

        SecretarioDespacho GetSecretarioOficina(Oficina oficina);
        // Obtiene solo uno
        SecretarioDespacho GetSecretario(int idSecretario);
        // Guardar en la base de datos
        SecretarioDespacho AddSecretario(SecretarioDespacho secretario);
        // Actualizar
        SecretarioDespacho UpdateSecretario(SecretarioDespacho secretario, Gobernacion gobernacion);
        // ELiminar
        bool DeleteSecretario(int idSecretario);   
    }
}