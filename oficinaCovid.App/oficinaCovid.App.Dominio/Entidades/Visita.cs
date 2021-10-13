using System;

namespace oficinaCovid.App.Dominio
{
    public class Visita
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraIngreso { get; set; }
        public DateTime HoraSalida { get; set; }
        public Persona Persona { get; set; }
        public Oficina Oficina { get; set; }
    }
}