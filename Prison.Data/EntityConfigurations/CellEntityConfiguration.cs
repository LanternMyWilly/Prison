using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prison.Models.Entities.Cell;

namespace Prison.Data.EntityConfigurations;

public class CellEntityConfiguration : IEntityTypeConfiguration<Cell>
{
    public void Configure(EntityTypeBuilder<Cell> builder)
    {
        builder.Property(e => e.Capacity).IsRequired();
        builder.Property(e => e.IsDeleted);

        builder.Property(e => e.CellTypeId).IsRequired();
    }
}