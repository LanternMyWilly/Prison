using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Stoelendans.Contracts.Commands;

public class UpdatePrisonCommand : CommandBase<PrisonDto>
{
    [JsonProperty("id")]
    public Guid Id { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("maxCapacity")]
    public int MaxCapacity { get; set; }
    [JsonProperty("currentCapacity")]
    public int CurrentCapacity { get; set; }

    [JsonConstructor]
    public UpdatePrisonCommand()
    {
    }
}