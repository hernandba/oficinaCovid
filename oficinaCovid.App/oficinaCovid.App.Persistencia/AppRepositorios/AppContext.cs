using Microsoft.EntityFrameworkCore;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class AppContext : DbContext
    {
        //Se debe crear una propiedad por cada una de las entidades del dominio
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }
        public DbSet<Sintomatologia> Sintomatologias { get; set; }
        public DbSet<Aseador> Aseadores { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Administrativo> Administrativos { get; set; }
        public DbSet<Secretario> Secretarios { get; set; }
        public DbSet<Sede> Sedes { get; set; }
        public DbSet<Oficina> Oficinas { get; set; }
        public DbSet<Disponibilidad> Disponibilidades { get; set; }
        public DbSet<Administrativo_Oficina> Administrativos_Oficinas { get; set; }
        public DbSet<Aseador_Sede> Aseadores_Sedes { get; set; }
        public DbSet<Proveedor_Sede> Proveedores_Sedes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrativo_Oficina>(eb => {
                eb.HasNoKey();
            });

            modelBuilder.Entity<Aseador_Sede>(eb => {
                eb.HasNoKey();
            });
            
            modelBuilder.Entity<Proveedor_Sede>(eb => {
                eb.HasNoKey();
            });
        }

        //Funcion que configura la conexion con la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = OficinaCovid.Data");
																									//Nombre del Servidor             Nombre de la BD
            }
        }
    }
}