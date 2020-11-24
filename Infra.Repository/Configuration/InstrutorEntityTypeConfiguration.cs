using Fructuoso.Template.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fructuoso.Template.Infra.Repository.Configuration
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
