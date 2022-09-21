using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Stoelendans.Contracts.Commands.Cell;

public class UpdateCellCommand : CommandBase<CellDto>
{
    [JsonProperty("capacity")]
    public string? Capacity { get; set; }
    [JsonProperty("cellTypeId")]
    public int? CellTypeId { get; set; }
    
    [JsonConstructor]
    public UpdateCellCommand()
    {
        
    }
}