using System;
using Capstone.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
        public virtual DbSet<Profesor> Profesor { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.IdAlumno)
                    .HasName("PK__Alumno__43FBBAC7F90142EB");

                entity.Property(e => e.IdAlumno).HasColumnName("idAlumno");

                entity.Property(e => e.ApellidosAlumno)
                    .IsRequired()
                    .HasColumnName("apellidosAlumno")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EdadAlumno).HasColumnName("edadAlumno");

                entity.Property(e => e.NombresAlumno)
                    .IsRequired()
                    .HasColumnName("nombresAlumno")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profesor>(entity =>
            {
                entity.HasKey(e => e.IdProfesor)
                    .HasName("PK__Profesor__C377C3A1E36E3609");

                entity.Property(e => e.ApellidosProfesor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombresProfesor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

        }

    }
}
