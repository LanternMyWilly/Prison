using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Stoelendans.Contracts.Commands.Cell;

public class DeleteCellCommand : CommandBase<CellDto>
{
    [JsonProperty("id")]
    [Required]
    public Guid Id { get; set; }

    [JsonConstructor]
    public DeleteCellCommand(Guid id)
    {
        this.Id = id;
    }
}