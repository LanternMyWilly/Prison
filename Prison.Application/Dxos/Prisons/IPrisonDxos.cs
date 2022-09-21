using Prison.Contracts.Dtos;

namespace Prison.Application.Dxos.Prisons;

public interface IPrisonDxos
{
    PrisonDto MapPrisonDto(Models.Entities.Prison.Prison prison);
    List<PrisonDto> MapPrisonsDto(IEnumerable<Models.Entities.Prison.Prison> prisons);
}