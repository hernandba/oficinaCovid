using System.Collections.Generic;

namespace oficinaCovid.App.Dominio
{
    public class Gobernacion
    {
        public int id { get; set; }
        public string barrio { get; set; }
        public int numeroOficinas { get; set; }
        public List<Oficina> oficinas { get; set; }
        public List<PersonalProveedor> proveedores { get; set; }
        public List<PersonalAseo> aseadores { get; set; }
    }
}