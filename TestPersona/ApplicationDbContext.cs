using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TestPersona.Entidades;

namespace TestPersona
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Persona> Persona => Set<Persona>();
    }
}
