using Capstone.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Infrastructure.Data.Configurations
{
    public class ProfesorConfiguration : IEntityTypeConfiguration<Profesor>
    {
        public void Configure(EntityTypeBuilder<Profesor> builder)
        {
            builder.ToTable("Profesor");
            builder.HasKey(e => e.IdProfesor)
                .HasName("PK__Profesor__C377C3A1E36E3609");
            builder.Property(e => e.IdProfesor).HasColumnName("idProfesor");
            builder.Property(e => e.ApellidosProfesor)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.EdadProfesor).HasColumnName("edadProfesor");
            builder.Property(e => e.EstadoProfesor).HasColumnName("estadoProfesor");
            builder.Property(e => e.NombresProfesor)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
