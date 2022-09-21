using Newtonsoft.Json;
using Prison.Models.Entities.BehaviorLevel;
using Prison.Models.Entities.Gender;
using Prison.Models.Entities.SentenceGrade;

namespace Prison.Contracts.Dtos;

public class InmateDto
{
    [JsonProperty("id")]
    public Guid Id { get; set; }
    [JsonProperty("firstName")]
    public string FirstName { get; set; }
    [JsonProperty("lastName")]
    public string MaxCapacity { get; set; }
    [JsonProperty("socialSecurityNr")]
    public string SocialSecurityNr { get; set; }
    [JsonProperty("dob")]
    public DateTime DoB { get; set; }
    [JsonProperty("releaseDate")]
    public DateTime ReleaseDate { get; set; }
    [JsonProperty("gender")]
    public Gender Gender { get; set; }
    [JsonProperty("behaviorLevel")]
    public BehaviorLevel BehaviorLevel { get; set; }
    [JsonProperty("cell")]
    public Models.Entities.Cell.Cell Cell { get; set; }
    [JsonProperty("sentenceGrade")]
    public SentenceGrade SentenceGrade { get; set; }
    [JsonProperty("prison")]
    public Models.Entities.Prison.Prison Prison { get; set; }

}