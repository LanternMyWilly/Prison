using AutoMapper;
using Prison.Contracts.Dtos;

namespace Prison.Application.Dxos.Prisons;

public class PrisonDxos : IPrisonDxos
{
    private readonly IMapper _mapper;

    public PrisonDxos()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Models.Entities.Prison.Prison, PrisonDto>();
        });

        _mapper = config.CreateMapper();
    }
    
    public PrisonDto MapPrisonDto(Models.Entities.Prison.Prison prison)
    {
        throw new NotImplementedException();
    }

    public List<PrisonDto> MapPrisonsDto(IEnumerable<Models.Entities.Prison.Prison> prisons)
    {
        throw new NotImplementedException();
    }
}