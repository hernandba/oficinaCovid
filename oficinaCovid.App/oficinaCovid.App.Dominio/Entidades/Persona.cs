namespace oficinaCovid.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Genero { set; get; }
        public Diagnostico Diagnostico { set; get; }
    }
}