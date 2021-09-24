using System;

namespace oficinaCovid.App.Dominio
{
    public class PersonalAseo : Persona
    {
        public int id {get; set;}
        public DateTime horaIngreso {get; set;}
        public DateTime horaSalida {get; set;}
        public string nombreEmpresa { set; get; }
    }
}