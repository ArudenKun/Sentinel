using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Sentinel.Core.Entities;

public class NullContext : IContext
{
    public static IContext Instance { get; } = new NullContext();

    public DatabaseFacade Database => throw new NotImplementedException();

    public bool IsUniqueConstraintViolationException(DbUpdateException exception)
    {
        throw new NotImplementedException();
    }

    public Task RunMigrationsAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
