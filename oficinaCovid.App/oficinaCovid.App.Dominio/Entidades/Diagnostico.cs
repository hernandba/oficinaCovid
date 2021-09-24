using System;

namespace oficinaCovid.App.Dominio
{
    public class Diagnostico
    {   
        public int id {get; set;}
        public bool infectado {get; set;}
        public DateTime fechaDiagnostico  {get; set;}
        public int fiasAislamiento {get; set;}
        public DateTime fechaFinAislamiento  {get; set;}
        public SintomasCovid sintomas {get; set;}
    }
}