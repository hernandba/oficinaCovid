using System;

namespace oficinaCovid.App.Dominio
{
    public class PersonalProveedor : Persona
    {   
        public int id {get; set;}
        public string servicioRealizado { get; set; }
        public string nombreEmpresa { set; get; }
    }
}