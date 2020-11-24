using Capstone.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Infrastructure.Data.Configurations
{
    public class ExamenConfiguration : IEntityTypeConfiguration<Examen>
    {
        public void Configure(EntityTypeBuilder<Examen> builder)
        {
            builder.HasKey(e => e.IdExamen)
                    .HasName("PK__Examen__0E8DC9BE940D016C");

            builder.Property(e => e.NotaExamen).HasColumnType("decimal(5, 2)");

            builder.HasOne(d => d.IdAlumnoNavigation)
                .WithMany(p => p.Examen)
                .HasForeignKey(d => d.IdAlumno)
                .HasConstraintName("FK__Examen__IdAlumno__3D5E1FD2");

            builder.HasOne(d => d.IdCursoNavigation)
                .WithMany(p => p.Examen)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK__Examen__IdCurso__3F466844");

            builder.HasOne(d => d.IdProfesorNavigation)
                .WithMany(p => p.Examen)
                .HasForeignKey(d => d.IdProfesor)
                .HasConstraintName("FK__Examen__IdProfes__3E52440B");
        }
    }
}
