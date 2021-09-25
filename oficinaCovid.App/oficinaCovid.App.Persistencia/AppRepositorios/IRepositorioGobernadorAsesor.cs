using System.Collections.Generic;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public interface IRepositorioGobernadorAsesor
    {
        // CRUD
        // Obtiene todos los gobernadores / Asesores
        IEnumerable<GobernadorAsesor> GetAll();
        // Obtiene a todos dependiendo del rol
        IEnumerable<GobernadorAsesor> GetAllGobAse(string rol);
        // Obtiene solo uno
        GobernadorAsesor GetGA(int idGobAse);
        // Guardar en la base de datos
        GobernadorAsesor AddGA(GobernadorAsesor gobernadorAsesor);
        // Actualizar
        GobernadorAsesor UpdateGA(GobernadorAsesor gobernadorAsesor);
        // ELiminar
        bool DeleteGA(int idGobernadorAsesor);
    }
}