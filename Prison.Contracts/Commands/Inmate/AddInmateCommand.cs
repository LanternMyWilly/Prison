using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Stoelendans.Contracts.Commands;

public class AddInmateCommand : CommandBase<InmateDto>
{
    [JsonProperty("firstName")]
    public string FirstName { get; set; }
    [JsonProperty("lastName")]
    public string LastName { get; set; }
    [JsonProperty("dob")]
    public string DoB { get; set; }
    [JsonProperty("socialSecurityNr")]
    public string SocialSecurityNr { get; set; }
    [JsonProperty("genderId")]
    public int GenderId { get; set; }
    [JsonProperty("behaviorLevelId")]
    public int BehaviorLevelId { get; set; }
    [JsonProperty("sentenceGradeId")]
    public int SentenceGradeId { get; set; }
    [JsonProperty("releaseDate")]
    public string ReleaseDate { get; set; }
    [JsonProperty("prisonId")]
    public int PrisonId { get; set; }

    [JsonConstructor]
    public AddInmateCommand(
        string firstName, 
        string lastName, 
        string dob,
        string socialSecurityNr,
        int genderId,
        int behaviorLevelId,
        int sentenceGradeId,
        string releaseDate,
        int prisonId, string doB)
    {
        FirstName = firstName;
        LastName = lastName;
        SocialSecurityNr = socialSecurityNr;
        ReleaseDate = releaseDate;
        DoB = doB;
        GenderId = genderId;
        BehaviorLevelId = behaviorLevelId;
        SentenceGradeId = sentenceGradeId;
        ReleaseDate = releaseDate;
        PrisonId = prisonId;
    }
}