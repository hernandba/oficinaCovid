using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioAseador
    {
        // Métodos CRUD
        // Obtener todo los registros del personal de aseo
        IEnumerable<PersonalAseo> GetAllPersonalAseo();
        // Obtener solo un aseador
        PersonalAseo GetAseador(int aseadorId);
        // Guardar registro
        PersonalAseo AddAseador(PersonalAseo aseadorNuevo);
        // Actualizar registro
        PersonalAseo UpdateAseador(PersonalAseo aseador);
        // Eliminar registro
        bool DeleteAseador(int aseadorId);
    }
}