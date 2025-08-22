using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using R3;
using Sentinel.Common.Extensions;
using Sentinel.Dependency;
using Sentinel.Localization;

namespace Sentinel.ViewModels.Windows;

[ServiceLifetime(ServiceLifetime.Singleton)]
public partial class MainWindowViewModel : ViewModel
{
    private readonly ILogger<MainWindowViewModel> _logger;

    public MainWindowViewModel(ILogger<MainWindowViewModel> logger)
    {
        _logger = logger;

        Settings
            .ObservePropertyChanged(x => x.Language)
            .Subscribe(c =>
            {
                Localizer.Culture = c;
            })
            .AddTo(this);
    }

    [ObservableProperty]
    public partial Bitmap TestImage { get; set; } = AvaloniaResources.avalonia_logo_ico.AsBitmap();

    [RelayCommand]
    private void ShowException() { }
}
