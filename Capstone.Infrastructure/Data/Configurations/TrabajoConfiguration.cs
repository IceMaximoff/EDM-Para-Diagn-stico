using Capstone.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Infrastructure.Data.Configurations
{
    public class TrabajoConfiguration : IEntityTypeConfiguration<Trabajo>
    {
        public void Configure(EntityTypeBuilder<Trabajo> builder)
        {
            builder.HasKey(e => e.IdTrabajo)
                    .HasName("PK__Trabajo__4FB29E34730F2F5F");

            builder.Property(e => e.NotaTrabajo).HasColumnType("decimal(5, 2)");

            builder.HasOne(d => d.IdAlumnoNavigation)
                .WithMany(p => p.Trabajo)
                .HasForeignKey(d => d.IdAlumno)
                .HasConstraintName("FK__Trabajo__IdAlumn__38996AB5");

            builder.HasOne(d => d.IdCursoNavigation)
                .WithMany(p => p.Trabajo)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK__Trabajo__IdCurso__3A81B327");

            builder.HasOne(d => d.IdProfesorNavigation)
                .WithMany(p => p.Trabajo)
                .HasForeignKey(d => d.IdProfesor)
                .HasConstraintName("FK__Trabajo__IdProfe__398D8EEE");
        }
    }
}
