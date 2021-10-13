using System.Collections.Generic;

namespace oficinaCovid.App.Dominio
{
    public class Gobernacion
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public int NumeroOficinas { get; set; }
        public Administrativo<List> Administrativos { get; set; }
        public Aseador<List> Aseadores { get; set; }
        public Proveedor<List> Proveedores { get; set; }
        public Secretario<List> Secretarios { get; set; }
        public Oficina<List> Oficinas { get; set; }
    }
}