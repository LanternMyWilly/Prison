using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prison.Models.Entities.Persons;
using Prison.Models.Entities.VisitorsLog;

namespace Prison.Data.EntityConfigurations;

public class VisitorsLogEntityConfiguration : IEntityTypeConfiguration<VisitorsLog>
{
    public void Configure(EntityTypeBuilder<VisitorsLog> builder)
    {
        builder.Property(e => e.MonthlyVisisted).IsRequired();
        builder.Property(e => e.DateOfVisit);
        builder.Property(e => e.IsDeleted);
        builder
            .HasMany<Inmate>(e => e.Inmates)
            .WithMany(e => e.VisitorsLogs);
    }
}