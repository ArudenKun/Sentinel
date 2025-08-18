using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Wpf.Hosting.Internal;

/// <summary>
/// A hosted service that manages the lifecycle of a Wpf thread.
/// </summary>
internal sealed class WpfHostedService : IHostedService
{
    private readonly WpfThread _thread;
    private readonly ILogger<WpfHostedService> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="WpfHostedService"/> class.
    /// </summary>
    /// <param name="thread">The Wpf thread to manage.</param>
    /// <param name="logger">The logger to use for logging information.</param>
    public WpfHostedService(WpfThread thread, ILogger<WpfHostedService> logger)
    {
        _thread = thread;
        _logger = logger;
    }

    /// <summary>
    /// Starts the Wpf thread.
    /// </summary>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous start operation.</returns>
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await _thread.StartAsync(cancellationToken);
        _logger.LogInformation("Wpf thread started");
    }

    /// <summary>
    /// Stops the Wpf thread.
    /// </summary>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous stop operation.</returns>
    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await _thread.StopAsync(cancellationToken);
        _logger.LogInformation("Wpf thread stopped");
    }
}
