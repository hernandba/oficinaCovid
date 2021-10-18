using System.Collections.Generic;

namespace oficinaCovid.App.Dominio
{
    public class Oficina
    {
        public int id { get; set; }
        public Gobernacion gobernacion {get; set;}
        public string numero { get; set; }
        public int aforo { get; set; }
        public SecretarioDespacho secretario { get; set; }
    }
}