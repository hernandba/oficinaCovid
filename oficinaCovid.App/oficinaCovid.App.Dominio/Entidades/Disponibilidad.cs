using System;

namespace oficinaCovid.App.Dominio
{
    public class Disponibilidad
    {   
        public int id {get; set;}
        public DateTime hora { get; set; }
        public bool disponible { get; set; }
    }
}