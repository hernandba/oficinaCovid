using System;
using System.Collections.Generic;
using oficinaCovid.App.Dominio;
using oficinaCovid.App.Persistencia;

namespace oficinaCovid.App.Consola.Crud
{
    class GobernadorCrud
    {
        IRepositorioGobernadorAsesor _repoGobernador = new RepositorioGobernadorAsesor(new Persistencia.AppContext());
        

        // CRUD 
        // Adicionar Gobernador/Asesor
        public void AddGobernador()
        {
            /*var gobernador = new GobernadorAsesor
            {
                identificacion = "10052323999",
                nombres = "Jeison",
                apellidos = "Hurtado",
                edad = 20,
                genero = "Masculino",
                rol = "Asesor"
            };*/

             var gobernador = new GobernadorAsesor
            {
                identificacion = "20001299",
                nombres = "Karen",
                apellidos = "Gonzalez",
                edad = 21,
                genero = "Femenino",
                rol = "Gobernador",
                gobernacion = null
            };
            _repoGobernador.AddGA(gobernador);
        }

        public string UpdateGobernador(GobernadorAsesor gobernador)
        {
            gobernador.nombres = "Karen Lizeth";
            gobernador.apellidos = "González Viera";
            //gobernador = _repoGobernador.UpdateGA(gobernador, null);
            if (gobernador == null)
                return "No se pudo actualizar";
            
            return "Actualizado con exito.";
            
        }

        // Encontrar dato
        public GobernadorAsesor EncontrarGobernador(int idGobernador)
        {
            var gobernadorEncontrado = _repoGobernador.GetGA(idGobernador);
            
            return gobernadorEncontrado;
        }

        // Encontrar por rol
        public IEnumerable<GobernadorAsesor> EncontrarPorRol(string rol)
        {
            var gobernadorEncontrado = _repoGobernador.GetAllGobAse(rol);
            
            return gobernadorEncontrado;
        }

        // Eliminar
        public bool EliminarGobernador(int idGobernadorAsesor)
        {
            return _repoGobernador.DeleteGA(idGobernadorAsesor);
        }
    }
}