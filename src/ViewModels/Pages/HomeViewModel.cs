using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Wpf.Ui;

namespace Sentinel.ViewModels.Pages;

public sealed partial class HomeViewModel : ViewModel
{
    private readonly ISnackbarService _snackbarService;
    private readonly IContentDialogService _contentDialogService;

    public HomeViewModel(
        ISnackbarService snackbarService,
        IContentDialogService contentDialogService
    )
    {
        _snackbarService = snackbarService;
        _contentDialogService = contentDialogService;
    }

    [ObservableProperty]
    public partial int Counter { get; set; } = 0;

    [RelayCommand]
    private async Task OnCounterIncrement()
    {
        Counter++;
        throw new NotImplementedException("Testing");
        // Wpf.Ui.Controls.ContentDialog dialog = new()
        // {
        //     Title = "My sample dialog",
        //     Content = "Content of the dialog",
        //     CloseButtonText = "Close button",
        //     PrimaryButtonText = "Primary button",
        //     SecondaryButtonText = "Secondary button",
        // };
        // await dialog.ShowAsync();
    }
}
