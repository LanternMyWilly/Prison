using Prison.Models.Entities.Persons;

namespace Prison.Models.Entities.VisitorsLog;

public class VisitorsLog : BaseAuditableEntity
{
    public bool MonthlyVisisted { get; set; } = false;
    public DateTime DateOfVisit { get; set; }
    public virtual ICollection<Inmate> Inmates { get; set; }
}