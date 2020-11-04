using System;
using Capstone.Core.Entities;
using Capstone.Infrastructure.Data.Configurations;
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
            modelBuilder.ApplyConfiguration(new AlumnoConfiguration());

            modelBuilder.ApplyConfiguration(new ProfesorConfiguration());

        }

    }
}
