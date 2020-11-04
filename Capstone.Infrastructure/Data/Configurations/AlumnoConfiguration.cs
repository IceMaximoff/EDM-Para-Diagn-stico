using Capstone.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Capstone.Infrastructure.Data.Configurations
{
    public class AlumnoConfiguration : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> builder)
        {
            builder.ToTable("Alumno");
            builder.HasKey(e => e.IdAlumno)
                .HasName("PK__Alumno__43FBBAC7F90142EB");

            builder.Property(e => e.IdAlumno).HasColumnName("idAlumno");

            builder.Property(e => e.ApellidosAlumno)
                .IsRequired()
                .HasColumnName("apellidosAlumno")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.EdadAlumno).HasColumnName("edadAlumno");
            builder.Property(e => e.EstadoAlumno).HasColumnName("estadoAlumno");
            builder.Property(e => e.NombresAlumno)
                .IsRequired()
                .HasColumnName("nombresAlumno")
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
