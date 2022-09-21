using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Prison.Contracts.Query.Prison;

public class GetPrisonQuery : QueryBase<PrisonDto>
{
    [JsonProperty("id")]
    [Required]
    public Guid Id { get; set; }

    [JsonConstructor]
    public GetPrisonQuery(Guid id)
    {
        this.Id = id;
    }
}