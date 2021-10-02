using System;

namespace oficinaCovid.App.Dominio
{
    public class GobernacionProveedor : Persona
    {   
        public int gobernacionId {get; set;}
        public int proveedorId {get; set;}
        public Gobernacion gobernacion {get; set;}
        public PersonalProveedor proveedor {get; set;}
    }
}