using Newtonsoft.Json;
using Prison.Models.Entities.BehaviorLevel;
using Prison.Models.Entities.CellType;
using Prison.Models.Entities.Gender;
using Prison.Models.Entities.SentenceGrade;

namespace Prison.Contracts.Dtos;

public class CellDto
{
    [JsonProperty("id")]
    public Guid Id { get; set; }
    [JsonProperty("capacity")]
    public string Capacity { get; set; }
    [JsonProperty("cellType")]
    public CellType CellType { get; set; }
    [JsonProperty("prison")]
    public Models.Entities.Prison.Prison Prison { get; set; }
}