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
                horaIngreso = "6:30 AM",
                horaSalida = "4:30 PM",
                genero = "Masculino"
            };
            _repoAseador.AddAseador(aseador);
        }

        public string UpdateAseador(PersonalAseo aseador, Gobernacion gobernacion)
        {
            aseador.nombres = "Benjamin Alonso";
            aseador.apellidos = "Hernandez Perez";
            aseador.horaIngreso = "8:00 AM";
            aseador.horaSalida = "6:00 PM";
            aseador = _repoAseador.UpdateAseador(aseador, gobernacion.id);
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