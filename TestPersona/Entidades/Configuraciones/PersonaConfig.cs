using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace TestPersona.Entidades.Configuraciones
{
    public class PersonaConfig : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nombre).HasMaxLength(50);
            builder.Property(p => p.ApellidoPaterno).HasMaxLength(50);
            builder.Property(p => p.ApellidoMaterno).HasMaxLength(50);
        }
    }
}
