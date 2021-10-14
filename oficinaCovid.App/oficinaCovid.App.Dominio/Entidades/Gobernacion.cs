using System.Collections.Generic;

namespace oficinaCovid.App.Dominio
{
    public class Gobernacion
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public int NumeroOficinas { get; set; }
        public System.Collections.Generic.List<Administrativo> Administrativos { get; set; }
        public System.Collections.Generic.List<Aseador> Aseadores { get; set; }
        public System.Collections.Generic.List<Proveedor> Proveedores { get; set; }
        public System.Collections.Generic.List<Secretario> Secretarios { get; set; }
        public System.Collections.Generic.List<Oficina> Oficinas { get; set; }
    }
}