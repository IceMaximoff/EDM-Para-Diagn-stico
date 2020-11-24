using Capstone.Core.Entities;
using Capstone.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
namespace Capstone.Infrastructure.Data
{
    public partial class CapstoneDBContext : DbContext
    {
        public CapstoneDBContext()
        {
        }

        public CapstoneDBContext(DbContextOptions<CapstoneDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Calificacion> Calificacion { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Examen> Examen { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<PruebaEce> PruebaEce { get; set; }
        public virtual DbSet<Trabajo> Trabajo { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlumnoConfiguration());
            modelBuilder.ApplyConfiguration(new ProfesorConfiguration());
            modelBuilder.ApplyConfiguration(new CalificacionConfiguration());
            modelBuilder.ApplyConfiguration(new CalificacionConfiguration());
            modelBuilder.ApplyConfiguration(new ExamenConfiguration());
            modelBuilder.ApplyConfiguration(new PruebaEceConfiguration());
            modelBuilder.ApplyConfiguration(new TrabajoConfiguration());
            modelBuilder.ApplyConfiguration(new CursoConfiguration());
        }

        
    }
}
