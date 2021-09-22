using System;

namespace oficinaCovid.App.Dominio
{
    public class Diagnostico
    {
        public bool Infectado {get; set;}
        public DateTime FechaDiagnostico  {get; set;}
        public int diasAislamiento {get; set;}
        public DateTime FechaFinAislamiento  {get; set;}
        public SintomasCovid sintomas {get; set;}
    }
}