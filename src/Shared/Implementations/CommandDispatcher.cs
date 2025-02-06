using Microsoft.Extensions.DependencyInjection;
using Shared.Common;

namespace Shared.Implementations;

public class CommandDispatcher(IServiceProvider serviceProvider) : ICommandDispatcher
{
    public async Task<TCommandResult> Dispatch<TCommand, TCommandResult>(
        TCommand command,
        CancellationToken cancellationToken)
    {
        var handler = serviceProvider.GetRequiredService<ICommandHandler<TCommand, TCommandResult>>();
        return await handler.Handle(command, cancellationToken);
    }
}