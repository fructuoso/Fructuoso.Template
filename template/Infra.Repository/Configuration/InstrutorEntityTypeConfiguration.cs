using $ext_rootnamespace$.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace $ext_rootnamespace$.$safeprojectname$.Configuration
{
    public class InstrutorEntityTypeConfiguration : IEntityTypeConfiguration<Instrutor>
    {
        public void Configure(EntityTypeBuilder<Instrutor> builder)
        {
            builder.Property(o => o.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(o => o.Nome).IsRequired();
            builder.Property(o => o.Email).IsRequired();
        }
    }
}
