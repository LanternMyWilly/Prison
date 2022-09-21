using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Prison.Data.EntityConfigurations;

public class PrisonEntityConfiguration : IEntityTypeConfiguration<Models.Entities.Prison.Prison>
{
    public void Configure(EntityTypeBuilder<Models.Entities.Prison.Prison> builder)
    {
        builder.Property(e => e.Name).IsRequired();

        builder.Property(e => e.MaxCapacity).IsRequired();

        builder.Property(e => e.CurrentCapacity).IsRequired();

        builder.Property(e => e.IsDeleted);
        
        
    } 
}