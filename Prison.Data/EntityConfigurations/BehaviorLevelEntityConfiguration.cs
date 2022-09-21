using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prison.Models.Entities.BehaviorLevel;

namespace Prison.Data.EntityConfigurations;

public class BehaviorLevelEntityConfiguration : IEntityTypeConfiguration<BehaviorLevel>
{
    public void Configure(EntityTypeBuilder<BehaviorLevel> builder)
    {
        builder.Property(e => e.LevelName).IsRequired();
        builder.Property(e => e.IsDeleted);
    }
}