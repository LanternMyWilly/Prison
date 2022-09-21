namespace Prison.Models.Entities.Persons;

public class Inmate : Person
{
    public DateTime ReleaseDate { get; set; }
    public Guid BehaviorLevelId { get; set; }
    public virtual BehaviorLevel.BehaviorLevel BehaviorLevel  { get; set; }
    public Guid CellId { get; set; }
    public virtual Cell.Cell Cell { get; set; }
    
    public Guid SentenceGradeId { get; set; }
    public virtual SentenceGrade.SentenceGrade SentenceGrade { get; set; }
    
    public virtual ICollection<VisitorsLog.VisitorsLog> VisitorsLogs { get; set; }
}