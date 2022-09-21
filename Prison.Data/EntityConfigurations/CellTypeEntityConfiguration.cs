using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prison.Models.Entities.CellType;

namespace Prison.Data.EntityConfigurations;

public class CellTypeEntityConfiguration : IEntityTypeConfiguration<CellType>
{
    public void Configure(EntityTypeBuilder<CellType> builder)
    {
        builder.Property(e => e.Name).IsRequired();
        builder.Property(e => e.IsDeleted);
    }
}