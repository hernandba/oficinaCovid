using System;

namespace oficinaCovid.App.Dominio
{
    public class Diagnostico
    {
        public int Id {get; set;}
        public bool Positivo {get; set;}
        public DateTime FechaDiagnostico  {get; set;}
        public int DiasAislamiento {get; set;}
        public DateTime FechaFinAislamiento  {get; set;}
        public Persona Persona {get; set;}
        public Sintomatologia Sintomatologia {get; set;}
    }
}