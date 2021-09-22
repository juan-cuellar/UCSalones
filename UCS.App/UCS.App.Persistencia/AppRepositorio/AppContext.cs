using Microsoft.EntityFrameworkCore;
using UCS.App.Dominio;

namespace UCS.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Directivo> Directivos {get;set;}
        public DbSet<Estudiante> Estudiantes {get;set;}
        public DbSet<PersonalAseo> PersonaldeAseo {get;set;}
        public DbSet<Profesores> Profesores {get;set;}
        public DbSet<Salones> Salones {get;set;}
        public DbSet<Sedes> Sedes {get;set;}
        public DbSet<SistemaIngresoPersonal> SistemaIngresoPersonal {get;set;}
        public DbSet<Universidad> Universidades {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = UCSalonesGrupo.Data");
            }
        }
    }
}