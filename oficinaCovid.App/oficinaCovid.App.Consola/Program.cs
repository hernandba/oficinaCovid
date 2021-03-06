using System;
using oficinaCovid.App.Dominio;
using oficinaCovid.App.Persistencia;
using oficinaCovid.App.Consola.Crud;

namespace oficinaCovid.App.Consola
{
    class Program
    {   
        private static GobernadorCrud gobernador = new GobernadorCrud();
        private static SecretarioCrud secretario_crud = new SecretarioCrud();
        private static AseadorCrud aseadorCrud = new AseadorCrud();
        static void Main(string[] args)
        {
        // Gobernador / Asesor
            //gobernador.AddGobernador();
            //GobernadorAsesor gob1 = gobernador.EncontrarGobernador(1);
            GobernadorAsesor gob2 = gobernador.EncontrarGobernador(1);
            //Console.WriteLine("Nombre: " + gob1.nombres + " " + gob1.apellidos + "\nRol: " + gob1.rol);
            Console.WriteLine("Nombre: " + gob2.nombres + " " + gob2.apellidos + "\nRol: " + gob2.rol);
            

            Console.WriteLine(gobernador.UpdateGobernador(gob2));
            gob2 = gobernador.EncontrarGobernador(1);
            Console.WriteLine("Nombre (Actualizado): " + gob2.nombres + " " + gob2.apellidos + "\nRol: " + gob2.rol);

            var eliminado = gobernador.EliminarGobernador(1);
            if (eliminado)
            {
                Console.WriteLine("Persona eliminada del sistema.");
            } else {
                Console.WriteLine("No se pudo eliminar.");
            }

        // Secretario
            secretario_crud.AddSecretario();
            SecretarioDespacho secretario_ins = secretario_crud.GetSecretario(2);
            Console.WriteLine("Nombre: " + secretario_ins.nombres + " " + secretario_ins.apellidos);

        // Personal de aseo
            aseadorCrud.AddAseador();
            PersonalAseo aseador_inst = aseadorCrud.GetAseador(3);
            Console.WriteLine("IdAseador: " + aseador_inst.id + " Aseador: " + aseador_inst.nombres + " " + aseador_inst.apellidos);
            
        }
    }
}
