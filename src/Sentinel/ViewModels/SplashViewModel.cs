using CommunityToolkit.Mvvm.Messaging;
using Humanizer;
using Microsoft.Extensions.Logging;
using Sentinel.Models.Messages;

namespace Sentinel.ViewModels;

public sealed class SplashViewModel : ViewModel
{
    private readonly ILogger<SplashViewModel> _logger;

    public SplashViewModel(ILogger<SplashViewModel> logger)
    {
        _logger = logger;
    }

    public override async void OnLoaded()
    {
        try
        {
            await Task.Delay(10.Seconds());
            Messenger.Send(new SplashFinishedMessage());
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Unhandled Exception");
        }
    }
}
