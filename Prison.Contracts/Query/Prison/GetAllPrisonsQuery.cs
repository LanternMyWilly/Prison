using Newtonsoft.Json;
using Prison.Contracts.Dtos;

namespace Prison.Contracts.Query.Prison;

public class GetAllPrisonsQuery : QueryBase<IEnumerable<PrisonDto>>
{
    [JsonConstructor]
    public GetAllPrisonsQuery()
    {
        
    }
}