using System;
using System.Collections.Generic;
using oficinaCovid.App.Dominio;
using oficinaCovid.App.Persistencia;

namespace oficinaCovid.App.Consola.Crud
{
    class AseadorCrud
    {
        IRepositorioAseador _repoAseador = new RepositorioAseador(new Persistencia.AppContext());

        public void AddAseador()
        {
            var aseador = new PersonalAseo
            {
                identificacion = "9855226",
                nombres = "Benjamin",
                apellidos = "Hernandez",
                edad = 58,
                genero = "Masculino"
            };
            _repoAseador.AddAseador(aseador);
        }

        public string UpdateAseador(PersonalAseo aseador)
        {
            aseador.nombres = "Benjamin Alonso";
            aseador.apellidos = "Hernandez Perez";
            aseador = _repoAseador.UpdateAseador(aseador);
            if (aseador == null)
                return "No se pudo actualizar.";
            return "Aseador actualizado con exito.";
        }

        public PersonalAseo GetAseador(int idAseador)
        {
            var aseador = _repoAseador.GetAseador(idAseador);
            return aseador;
        }

        public bool DeleteAseador(int idAseador)
        {
            return _repoAseador.DeleteAseador(idAseador);
        }
    }
}