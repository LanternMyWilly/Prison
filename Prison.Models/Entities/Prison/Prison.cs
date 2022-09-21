using Prison.Models.Entities.CellType;
using Prison.Models.Entities.Persons;

namespace Prison.Models.Entities.Prison;

public class Prison : BaseAuditableEntity
{
    public string Name { get; set; }
    public int MaxCapacity { get; set; }
    public int CurrentCapacity { get; set; }
    public virtual ICollection<Cell.Cell> Cells { get; set; }
    public virtual ICollection<Inmate> Inmates { get; set; }
}