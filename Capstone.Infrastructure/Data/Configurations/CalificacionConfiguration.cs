using Capstone.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Infrastructure.Data.Configurations
{
    public class CalificacionConfiguration : IEntityTypeConfiguration<Calificacion>
    {
        public void Configure(EntityTypeBuilder<Calificacion> builder)
        {
            builder.HasKey(e => e.IdCalificacion)
                    .HasName("PK__Califica__40E4A75132B37E76");

            builder.Property(e => e.ValorCalificacion).HasColumnType("decimal(5, 2)");

            builder.HasOne(d => d.IdAlumnoNavigation)
                .WithMany(p => p.Calificacion)
                .HasForeignKey(d => d.IdAlumno)
                .HasConstraintName("FK__Calificac__IdAlu__4222D4EF");

            builder.HasOne(d => d.IdCursoNavigation)
                .WithMany(p => p.Calificacion)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK__Calificac__IdCur__440B1D61");

            builder.HasOne(d => d.IdProfesorNavigation)
                .WithMany(p => p.Calificacion)
                .HasForeignKey(d => d.IdProfesor)
                .HasConstraintName("FK__Calificac__IdPro__4316F928");
        }
    }
}
