using System;

namespace oficinaCovid.App.Dominio
{
    public class Disponibilidad
    {
        public int Id { get; set; }
        public DateTime Hora { get; set; }
        public bool Disponible { get; set; }
    }
}