using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class EscuelaDbContext(DbContextOptions<EscuelaDbContext> options) : DbContext(options)
    {
        public DbSet<Alumno> Alumnos => Set<Alumno>(); 
        protected override void OnModelCreating(ModelBuilder Builder)
        {
          Builder.Entity<Alumno>(entity =>
          {
              entity.HasKey(e => e.Id);
              entity.Property(e => e.Nombre).IsRequired().HasMaxLength(100);
              entity.Property(e => e.Apellido).IsRequired().HasMaxLength(100);
              entity.Property(e => e.Edad).IsRequired();
          });

        }
    }
}
