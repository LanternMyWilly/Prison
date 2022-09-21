using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Prison.Models.Entities.BehaviorLevel;
using Prison.Models.Entities.Cell;
using Prison.Models.Entities.CellType;
using Prison.Models.Entities.Gender;
using Prison.Models.Entities.Persons;
using Prison.Models.Entities.Prison;
using Prison.Models.Entities.SentenceGrade;
using Prison.Models.Entities.VisitorsLog;

namespace Prison.Data
{
    public class PrisonDbContext : DbContext
    {
        public DbSet<Inmate> Inmates { get; set; }
        public DbSet<BehaviorLevel> BehaviorLevels { get; set; }
        public DbSet<CellType> CellTypes { get; set; }
        public DbSet<Models.Entities.Prison.Prison> Prisons { get; set; }
        public DbSet<VisitorsLog> VisitorsLogs { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<SentenceGrade> SentenceGrades { get; set; }

        public PrisonDbContext(DbContextOptions<PrisonDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            this.AddAuditInfo();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            this.AddAuditInfo();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
