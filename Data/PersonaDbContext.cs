using backend.Domain;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace backend.Data
{
    public class PersonaDbContext : DbContext
    {
        public DbSet<Persona> Persona {get; set;}
        public PersonaDbContext(DbContextOptions<PersonaDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=54.236.22.20;database=tp;user=taller;password=tallerREDES2022.");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Persona>(entity => entity.HasKey(p => p.Id));
        }
    }
}