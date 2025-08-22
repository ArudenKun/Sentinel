using DependencyPropertyGenerator;
using Sentinel.ViewModels.Windows;
using Sentinel.Views.Abstractions;

namespace Sentinel.Views.Windows;

[DependencyProperty<string>("AppName")]
[DependencyProperty<string>("AppVersion")]
public partial class ExceptionWindow : SukiWindow<ExceptionWindowViewModel>
{
    public ExceptionWindow()
    {
        InitializeComponent();
    }

    // public Exception ExceptionObject { get; set; }
    // public string ExceptionType => ExceptionObject.GetType().ToString();
    //
    // public string ErrorTime { get; } = DateTime.Now.ToString(CultureInfo.InvariantCulture);
    //
    // // ReSharper disable once InconsistentNaming
    // public string OSVersion { get; } = "Windows " + Environment.OSVersion;
    //
    // public ExceptionWindow(Exception? e, string? appName = null, string? appVersion = null)
    // {
    //     ExceptionObject = e ?? new Exception("<NULL>");
    //     AppName =
    //         appName ?? (Owner as Window)?.Title ?? typeof(ExceptionWindow).Assembly.GetName().Name;
    //     AppVersion = appVersion ?? "v" + typeof(ExceptionWindow).Assembly.GetName().Version;
    //
    //     DataContext = this;
    //     InitializeComponent();
    //
    //     Title = "Error Occured";
    //     Hint1TextBlock.Text = "Exception Raised";
    //     Hint2TextBlock.Text =
    //         "You can copy the info to track the problem, ignore and try, or exit the program and restart.";
    //     CopyTextBlock.Text = "Copy";
    //     IgnoreTextBlock.Text = "Ignore";
    //     ExitTextBlock.Text = "Exit";
    //
    //     CopyButton.Click += (_, _) => CopyInfo();
    //     TryIgnoreButton.Click += (_, _) => IgnoreAndTry();
    //     ExitButton.Click += (_, _) => ExitApp();
    // }
    //
    // public string GetInfo()
    // {
    //     StringBuilder sb = new();
    //
    //     sb.AppendLine($"{AppName} {AppVersion}")
    //         .AppendLine($"{ErrorTime} {OSVersion}")
    //         .AppendLine("```")
    //         .AppendLine(ExceptionObject.ToString())
    //         .AppendLine("```");
    //
    //     return sb.ToString();
    // }
    //
    // public void CopyInfo()
    // {
    //     Task.Run(async () =>
    //         {
    //             DispatcherHelper.Post(() => Clipboard?.SetTextAsync(GetInfo()));
    //
    //             DispatcherHelper.Post(() => ToolTip.SetTip(CopyButton, "Copied to clipboard"));
    //             DispatcherHelper.Post(() => ToolTip.SetIsOpen(CopyButton, true));
    //             await Task.Delay(1000);
    //             DispatcherHelper.Post(() => ToolTip.SetIsOpen(CopyButton, false));
    //             DispatcherHelper.Post(() => ToolTip.SetTip(CopyButton, "Copy to clipboard"));
    //         })
    //         .SafeFireAndForget(exception => LogHelper.Error(exception, "Failed to copy info"));
    // }
    //
    // public void IgnoreAndTry()
    // {
    //     Close();
    // }
    //
    // public void ExitApp()
    // {
    //     IgnoreAndTry();
    //     App.ApplicationLifetime.TryShutdown();
    // }
    //
    // public static void Show(Exception e, string? appName = null, string? appVersion = null)
    // {
    //     var owner = App.MainWindow;
    //     DispatcherHelper.Invoke(() =>
    //         _ = new ExceptionWindow(e, appName, appVersion).ShowDialog(owner)
    //     );
    // }
    //
    // public static async Task ShowAsync(
    //     Exception e,
    //     string? appName = null,
    //     string? appVersion = null
    // )
    // {
    //     var owner = App.MainWindow;
    //     await DispatcherHelper.InvokeAsync(() =>
    //         _ = new ExceptionWindow(e, appName, appVersion).ShowDialog(owner)
    //     );
    // }
}
