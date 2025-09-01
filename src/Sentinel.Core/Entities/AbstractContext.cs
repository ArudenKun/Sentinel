using Microsoft.EntityFrameworkCore;

namespace Sentinel.Core.Entities;

public abstract class AbstractContext<TContext> : DbContext, IContext
    where TContext : DbContext
{
    protected AbstractContext(DbContextOptions<TContext> options)
        : base(options) { }

    public Task<int> SaveChangesAsync() => SaveChangesAsync(CancellationToken.None);

    public abstract bool IsUniqueConstraintViolationException(DbUpdateException exception);

    public virtual async Task RunMigrationsAsync(CancellationToken cancellationToken) =>
        await Database.MigrateAsync(cancellationToken);
}
