using System;

namespace oficinaCovid.App.Dominio
{
    public class GobernadorAsesor : Persona
    {
        public string rol { get; set; }
        public Gobernacion gobernacion {get; set;}
    }
}