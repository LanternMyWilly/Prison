using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Stoelendans.Contracts.Commands;

public class DeleteInmateCommand : CommandBase<InmateDto>
{
    [JsonProperty("id")]
    [Required]
    public Guid Id { get; set; }

    [JsonConstructor]
    public DeleteInmateCommand(Guid id)
    {
        this.Id = id;
    }
}