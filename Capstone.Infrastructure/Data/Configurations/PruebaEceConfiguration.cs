using Capstone.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Infrastructure.Data.Configurations
{
    public class PruebaEceConfiguration : IEntityTypeConfiguration<PruebaEce>
    {
        public void Configure(EntityTypeBuilder<PruebaEce> builder)
        {
            builder.HasKey(e => e.IdEce)
                    .HasName("PK__PruebaEC__0F3C80F7E27B18F8");

            builder.ToTable("PruebaECE");

            builder.Property(e => e.IdEce).HasColumnName("IdECE");

            builder.Property(e => e.EstadoEce).HasColumnName("EstadoECE");

            builder.Property(e => e.PuntajeEce)
                .HasColumnName("PuntajeECE")
                .HasColumnType("decimal(5, 2)");

            builder.HasOne(d => d.IdAlumnoNavigation)
                .WithMany(p => p.PruebaEce)
                .HasForeignKey(d => d.IdAlumno)
                .HasConstraintName("FK__PruebaECE__IdAlu__46E78A0C");

            builder.HasOne(d => d.IdCursoNavigation)
                .WithMany(p => p.PruebaEce)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK__PruebaECE__IdCur__48CFD27E");

            builder.HasOne(d => d.IdProfesorNavigation)
                .WithMany(p => p.PruebaEce)
                .HasForeignKey(d => d.IdProfesor)
                .HasConstraintName("FK__PruebaECE__IdPro__47DBAE45");
        }
    }
}
