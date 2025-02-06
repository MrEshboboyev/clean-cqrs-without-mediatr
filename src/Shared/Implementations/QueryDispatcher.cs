using Microsoft.Extensions.DependencyInjection;
using Shared.Common;

namespace Shared.Implementations;

public class QueryDispatcher(IServiceProvider serviceProvider) : IQueryDispatcher
{
    public async Task<TQueryResult> Dispatch<TQuery, TQueryResult>(
        TQuery query,
        CancellationToken cancellationToken)
    {
        var handler = serviceProvider.GetRequiredService<IQueryHandler<TQuery, TQueryResult>>();
        return await handler.Handle(query, cancellationToken);
    }
}