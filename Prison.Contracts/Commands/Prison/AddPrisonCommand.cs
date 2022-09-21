using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Stoelendans.Contracts.Commands;

public class AddPrisonCommand : CommandBase<PrisonDto>
{
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("maxCapacity")]
    public int MaxCapacity { get; set; }
    [JsonProperty("currentCapacity")]
    public int CurrentCapacity { get; set; }

    [JsonConstructor]
    public AddPrisonCommand(string name, int maxCapacity, int currentCapacity)
    {
        this.Name = name;
        this.MaxCapacity = maxCapacity;
        this.CurrentCapacity = currentCapacity;
    }
}