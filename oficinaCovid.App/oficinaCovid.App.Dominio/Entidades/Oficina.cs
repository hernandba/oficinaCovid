using System.Collections.Generic;

namespace oficinaCovid.App.Dominio
{
    public class Oficina
    {
        public int id { get; set; }
        public string numero { get; set; }
        public int aforo { get; set; }
        public List<Disponibilidad> horasDisponibles { get; set;}
        public List<GobernadorAsesor> visitantes { get; set; }
        public SecretarioDespacho secretario { get; set; }
    }
}