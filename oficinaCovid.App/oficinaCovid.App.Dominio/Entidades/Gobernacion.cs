using System.Collections.Generic;

namespace oficinaCovid.App.Dominio
{
    public class Gobernacion
    {
        public int Id { get; set; }
        public string Barrio { get; set; }
        public int NumeroOficinas { get; set; }
        public List<Oficina> Oficinas { get; set; }
        public List<PersonalProveedor> Proveedores { get; set; }
        public List<PersonalAseo> Aseadores { get; set; }
    }
}