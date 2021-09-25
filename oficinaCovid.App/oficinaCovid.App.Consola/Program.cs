using System;
using oficinaCovid.App.Dominio;
using oficinaCovid.App.Persistencia;

namespace oficinaCovid.App.Consola
{
    class Program
    {
        private static IRepositorioGobernadorAsesor _repoGobernador = new RepositorioGobernadorAsesor(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddGobernador();
            EncontrarGobernador(1);
        }

        // CRUD 
        // Adicionar Gobernador/Asesor
        private static void AddGobernador()
        {
            var gobernador = new GobernadorAsesor
            {
                identificacion = "10052323999",
                nombres = "Jeison",
                apellidos = "Hurtado",
                edad = 20,
                genero = "Masculino",
                diagnostico = null,
                rol = "Asesor"
            };
            _repoGobernador.AddGA(gobernador);
        }

        // Encontrar dato
        private static void EncontrarGobernador(int idGobernador)
        {
            var gobernadorEncontrado = _repoGobernador.GetGA(idGobernador);
            Console.WriteLine(gobernadorEncontrado.nombres + " " + gobernadorEncontrado.apellidos);
        }
    }
}
