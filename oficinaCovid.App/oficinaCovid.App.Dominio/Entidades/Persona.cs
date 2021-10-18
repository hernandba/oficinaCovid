namespace oficinaCovid.App.Dominio
{
    public class Persona
    {
        public int id { get; set; }
        public string identificacion { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string genero { set; get; }
    }
}