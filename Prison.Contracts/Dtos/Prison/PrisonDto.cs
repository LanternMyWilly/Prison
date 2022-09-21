using Newtonsoft.Json;

namespace Prison.Contracts.Dtos;

public class PrisonDto
{
    [JsonProperty("id")]
    public Guid Id { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("maxCapacity")]
    public string MaxCapacity { get; set; }
    [JsonProperty("currentCapacity")]
    public string currentCapacity { get; set; }
}