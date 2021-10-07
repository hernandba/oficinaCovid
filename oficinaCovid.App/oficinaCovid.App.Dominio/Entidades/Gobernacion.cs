using System;

namespace oficinaCovid.App.Dominio
{
    public class Gobernacion
    {
        //atributos
        public int id { get; set; }
        public string nombre { get; set; }
        public string ciudad { get; set; }
        public string direccion { get; set; }
        public int numeroOficinas { get; set; }
    }
}