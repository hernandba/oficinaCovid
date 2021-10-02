using Microsoft.EntityFrameworkCore;
using oficinaCovid.App.Dominio;

namespace oficinaCovid.App.Persistencia
{
    public class AppContext: DbContext
    {
        public DbSet<Persona> personas {get; set;}
        public DbSet<GobernadorAsesor> gobernadores {get; set;}
        public DbSet<SecretarioDespacho> secretarios {get; set;}
        public DbSet<PersonalAseo> aseadores {get; set;}
        public DbSet<PersonalProveedor> personalProveedor {get; set;}
        public DbSet<Gobernacion> gobernaciones {get; set;}
        public DbSet<Oficina> oficinas {get; set;}
        public DbSet<Disponibilidad> horasDisponibles {get; set;}
        public DbSet<SintomasCovid> sintomas {get; set;}
        public DbSet<Diagnostico> diagnosticos {get; set;}
        public DbSet<OficinaVisitante> oficinaVisitante {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OficinaVisitante>().HasKey(x => new 
            {
                x.oficinaId, x.visitanteId
            });

            modelBuilder.Entity<GobernacionProveedor>().HasKey(x => new
            {
                x.gobernacionId, x.proveedorId
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = OficinaCovid");
            }
        }
    }
}