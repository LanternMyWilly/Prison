namespace Prison.Models;

public abstract class BaseAuditableEntity : BaseEntity
{
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
}

