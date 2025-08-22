using System;
using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using Lucide.Avalonia;
using Microsoft.Extensions.Logging;

namespace Sentinel.ViewModels.Windows;

public sealed partial class ExceptionWindowViewModel : ViewModel
{
    private readonly ILogger<ExceptionWindowViewModel> _logger;

    public ExceptionWindowViewModel(ILogger<ExceptionWindowViewModel> logger)
    {
        _logger = logger;

        OSVersion = Native.GetOSVersionString();
    }

    [ObservableProperty]
    public partial string Title { get; set; } = "Error Occured";

    [ObservableProperty]
    public partial LucideIcon Icon { get; set; } = new() { Kind = LucideIconKind.BadgeX };

    [ObservableProperty]
    public partial string Hint1Text { get; set; } = "Exception Raised";

    [ObservableProperty]
    public partial string Hint2Text { get; set; } =
        "You can copy the info to track the problem, ignore and try, or exit the program and restart.";

    [ObservableProperty]
    public partial Exception ExceptionObject { get; set; } = new("<NULL>");

    [ObservableProperty]
    public partial string ExceptionType { get; set; } = "<NULL>";

    [ObservableProperty]
    public partial string ErrorTime { get; set; } =
        DateTime.Now.ToString(CultureInfo.InvariantCulture);

    // ReSharper disable once InconsistentNaming
    [ObservableProperty]
    public partial string OSVersion { get; set; }
}
