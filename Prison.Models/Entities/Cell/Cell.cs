using Prison.Models.Entities.Persons;

namespace Prison.Models.Entities.Cell;

public class Cell : BaseAuditableEntity
{
    public int Capacity { get; set; }
    public Guid CellTypeId { get; set; }
    public virtual CellType.CellType CellType { get; set; }
    public virtual ICollection<Inmate> Inmates { get; set; }
}