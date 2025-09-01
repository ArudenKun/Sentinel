using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Sentinel.Core.Entities;

namespace Sentinel.Database.Sqlite;

public class SqliteContext : AbstractContext<SqliteContext>
{
    /// <summary>
    /// The Sqlite error code for when a unique constraint is violated.
    /// </summary>
    private const int SqliteUniqueConstraintViolationErrorCode = 19;

    public SqliteContext(DbContextOptions<SqliteContext> options)
        : base(options) { }

    public override bool IsUniqueConstraintViolationException(DbUpdateException exception) =>
        exception.InnerException
            is SqliteException { SqliteErrorCode: SqliteUniqueConstraintViolationErrorCode };

    public override async Task RunMigrationsAsync(CancellationToken cancellationToken)
    {
        if (Database.GetDbConnection() is SqliteConnection connection)
        {
            /* Create the folder of the Sqlite blob if it does not exist. */
            EnsureDataSourceDirectoryExists(connection);
        }

        await base.RunMigrationsAsync(cancellationToken);
    }

    /// <summary>
    /// Creates directories specified in the Database::ConnectionString config for the Sqlite database file.
    /// </summary>
    /// <param name="connection">Instance of the <see cref="SqliteConnection"/>.</param>
    private static void EnsureDataSourceDirectoryExists(SqliteConnection connection)
    {
        var pathToCreate = Path.GetDirectoryName(connection.DataSource);

        if (string.IsNullOrWhiteSpace(pathToCreate))
            return;

        Directory.CreateDirectory(pathToCreate);
    }
}
