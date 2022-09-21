using MediatR;

namespace Prison.Contracts.Query;

public class QueryBase<T> : IRequest<T> where T : class
{
    
}