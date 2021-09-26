using System;
using System.Collections.Generic;
using oficinaCovid.App.Dominio;
using oficinaCovid.App.Persistencia;

namespace oficinaCovid.App.Consola.Crud
{
    class SecretarioCrud
    {
        IRepositorioSecretario _repSecretario = new RepositorioSecretario(new Persistencia.AppContext());
        

        // CRUD 
        // Adicionar Gobernador/Asesor
        public void AddSecretario()
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

            var secretario = new SecretarioDespacho
            {
                identificacion = "12299010",
                nombres = "Nicol",
                apellidos = "Valencia",
                edad = 19,
                genero = "Femenino"
            };
            _repSecretario.AddSecretario(secretario);
        }

        public string UpdateSecretario(SecretarioDespacho secretario)
        {
            secretario.nombres = "Nicol Andrea";
            secretario.apellidos = "Valencia Martinez";
            secretario = _repSecretario.UpdateSecretario(secretario);
            if (secretario == null)
                return "No se pudo actualizar";
            
            return "Actualizado con exito.";
            
        }

        // Encontrar dato
        public SecretarioDespacho GetSecretario(int idSecretario)
        {
            var secretarioEncontrado = _repSecretario.GetSecretario(idSecretario);
            
            return secretarioEncontrado;
        }

        // Eliminar
        public bool DeleteSecretario(int idSecretario)
        {
            return _repSecretario.DeleteSecretario(idSecretario);
        }
    }
}