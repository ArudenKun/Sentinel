using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Wpf.Hosting.Services;

namespace Wpf.Hosting.Internal;

/// <summary>
/// This is the configuration for the mutex service
/// </summary>
internal class MutexBuilder : IMutexBuilder
{
    /// <inheritdoc />
    public string MutexId { get; set; } = Guid.CreateVersion7().ToString();

    /// <inheritdoc />
    public bool IsGlobal { get; set; }

    /// <inheritdoc />
    public Action<IHostEnvironment, ILogger>? WhenNotFirstInstance { get; set; }
}
