using $ext_safeprojectname$.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace $ext_rootnamespace$.$safeprojectname$.Configuration
{
    public class CursoEntityTypeConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.Property(o => o.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(o => o.Nome).IsRequired();
            builder.Property(o => o.CargaHoraria).IsRequired();
            builder.HasMany(o => o.Instrutores).WithMany(o => o.Cursos);
        }
    }
}
