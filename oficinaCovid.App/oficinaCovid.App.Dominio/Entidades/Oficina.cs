using System.Collections.Generic;

namespace oficinaCovid.App.Dominio
{
    public class Oficina
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int Aforo { get; set; }
        public List<Disponibilidad> HorasDisponibles { get; set;}
        public List<GobernadoAsesor> Visitantes { get; set; }
        public SecretarioDespacho Secretario { get; set; }
    }
}