using Wpf.Ui.Violeta.Controls;

namespace Sentinel;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    public App()
    {
        InitializeComponent();
        DispatcherUnhandledException += (_, e) =>
        {
            e.Handled = true;
            HandleUnhandledException(e.Exception);
        };
        AppDomain.CurrentDomain.UnhandledException += (_, e) =>
            HandleUnhandledException((Exception)e.ExceptionObject);
        TaskScheduler.UnobservedTaskException += (_, e) =>
        {
            e.SetObserved();
            HandleUnhandledException(e.Exception);
        };
    }

    private static void HandleUnhandledException(Exception exception)
    {
        ExceptionReport.Show(exception, "", "");
    }
}
