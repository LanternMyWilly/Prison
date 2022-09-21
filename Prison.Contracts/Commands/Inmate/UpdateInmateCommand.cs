using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Stoelendans.Contracts.Commands;

public class UpdateInmateCommand : CommandBase<InmateDto>
{
    [JsonProperty("firstName")]
    public string? FirstName { get; set; }
    [JsonProperty("lastName")]
    public string? LastName { get; set; }
    [JsonProperty("dob")]
    public string? DoB { get; set; }
    [JsonProperty("socialSecurityNr")]
    public string? SocialSecurityNr { get; set; }
    [JsonProperty("genderId")]
    public int? GenderId { get; set; }
    [JsonProperty("behaviorLevelId")]
    public int? BehaviorLevelId { get; set; }
    [JsonProperty("sentenceGradeId")]
    public int? SentenceGradeId { get; set; }
    [JsonProperty("releaseDate")]
    public string? ReleaseDate { get; set; }
    [JsonProperty("prisonId")]
    public int? PrisonId { get; set; }

    [JsonConstructor]
    public UpdateInmateCommand()
    { }
}