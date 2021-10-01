namespace oficinaCovid.App.Dominio
{
    public class Sintomatologia
    {
        public int Id { get; set; }
        public bool Fiebre {get; set;}
        public bool PerdidaOlfato {get; set;}
        public bool PerdidaGusto {get; set;}
        public bool TosSeca {get; set;}
        public bool Desaliento {get; set;}
        public bool DolorGarganta {get; set;}
        public bool DificultadRespirar {get; set;}
    }
}