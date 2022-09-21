namespace Prison.Models.Entities.SentenceGrade;

public class SentenceGrade : BaseAuditableEntity
{
    public string Name { get; set; }
    public int Level { get; set; }
}