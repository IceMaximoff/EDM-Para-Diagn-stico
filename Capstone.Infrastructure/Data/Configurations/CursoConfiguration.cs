using Capstone.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Infrastructure.Data.Configurations
{
    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(e => e.IdCurso)
                    .HasName("PK__Curso__085F27D61D256495");

            builder.Property(e => e.NombreCurso)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
