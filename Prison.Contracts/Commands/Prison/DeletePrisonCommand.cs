using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Stoelendans.Contracts.Commands;

public class DeletePrisonCommand : CommandBase<PrisonDto>
{
    [JsonProperty("id")]
    [Required]
    public Guid Id { get; set; }

    [JsonConstructor]
    public DeletePrisonCommand(Guid id)
    {
        this.Id = id;
    }
}