using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prison.Models.Entities.Persons;

namespace Prison.Data.EntityConfigurations;

public class InmateEntityConfiguration : IEntityTypeConfiguration<Inmate>
{
    public void Configure(EntityTypeBuilder<Inmate> builder)
    {
        builder.Property(e => e.CellId).IsRequired();
        builder.Property(e => e.BehaviorLevelId).IsRequired();
        builder.Property(e => e.GenderId).IsRequired();
        builder.Property(e => e.SentenceGradeId).IsRequired();
        builder.Property(e => e.DoB).IsRequired();
        builder.Property(e => e.ReleaseDate).IsRequired();
        builder.Property(e => e.FirstName).IsRequired();
        builder.Property(e => e.LastName).IsRequired();
        builder.Property(e => e.SocialSecurityNr).IsRequired();
        builder.Property(e => e.IsDeleted);
    }
}