using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Stoelendans.Contracts.Commands.Cell;

public class AddCellCommand : CommandBase<CellDto>
{
    [JsonProperty("capacity")]
    public string Capacity { get; set; }
    [JsonProperty("cellTypeId")]
    public int CellTypeId { get; set; }
    [JsonProperty("prisonId")]
    public int PrisonId { get; set; }

    [JsonConstructor]
    public AddCellCommand(string capacity, int cellTypeId, int prisonId)
    {
        Capacity = capacity;
        CellTypeId = cellTypeId;
        PrisonId = prisonId;
    }
}