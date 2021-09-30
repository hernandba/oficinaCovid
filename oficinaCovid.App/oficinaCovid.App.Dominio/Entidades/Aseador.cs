using System;

namespace oficinaCovid.App.Dominio
{
    public class Aseador : Persona
    {
        public DateTime horaIngreso {get; set;}
        public DateTime horaSalida {get; set;}
        public string nombreEmpresa { set; get; }
        
    }
}