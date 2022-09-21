namespace Prison.Models;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public bool IsDeleted { get; private set; }
}
