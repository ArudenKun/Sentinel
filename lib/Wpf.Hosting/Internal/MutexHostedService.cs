using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Wpf.Hosting.Services;

namespace Wpf.Hosting.Internal;

/// <summary>
/// This maintains the mutex lifetime
/// </summary>
internal sealed class MutexHostedService : IHostedService
{
    private readonly ILogger _logger;
    private readonly IHostEnvironment _hostEnvironment;
    private readonly IHostApplicationLifetime _hostApplicationLifetime;
    private readonly IMutexBuilder _mutexBuilder;
    private ResourceMutex? _resourceMutex;

    public MutexHostedService(
        ILogger<MutexHostedService> logger,
        IHostEnvironment hostEnvironment,
        IHostApplicationLifetime hostApplicationLifetime,
        IMutexBuilder mutexBuilder
    )
    {
        _logger = logger;
        _hostEnvironment = hostEnvironment;
        _hostApplicationLifetime = hostApplicationLifetime;
        _mutexBuilder = mutexBuilder;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _resourceMutex = ResourceMutex.Create(
            null,
            _mutexBuilder.MutexId,
            _hostEnvironment.ApplicationName,
            _mutexBuilder.IsGlobal
        );

        _hostApplicationLifetime.ApplicationStopping.Register(OnStopping);
        if (!_resourceMutex.IsLocked)
        {
            _mutexBuilder.WhenNotFirstInstance?.Invoke(_hostEnvironment, _logger);
            _logger.LogDebug(
                "Application {applicationName} already running, stopping application.",
                _hostEnvironment.ApplicationName
            );
            _hostApplicationLifetime.StopApplication();
        }

        return Task.CompletedTask;
    }

    private void OnStopping()
    {
        _logger.LogInformation("OnStopping has been called, closing mutex.");
        _resourceMutex?.Dispose();
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
