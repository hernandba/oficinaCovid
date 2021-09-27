using System;

namespace oficinaCovid.App.Dominio
{
    public class OficinaVisitante
    {
        public int oficinaId {get; set;}
        public int visitanteId {get; set;}
        public Oficina oficina {get; set;}
        public GobernadorAsesor visitante {get; set;}
    }
}