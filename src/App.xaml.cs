using Microsoft.Extensions.Logging;
using Sentinel.Views.Windows;

namespace Sentinel;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    private readonly ILoggerFactory _loggerFactory;

    public App(ILoggerFactory loggerFactory)
    {
        _loggerFactory = loggerFactory;
        InitializeComponent();
        DispatcherUnhandledException += (_, e) =>
        {
            e.Handled = true;
            HandleUnhandledException(e.Exception, "UI");
        };
        AppDomain.CurrentDomain.UnhandledException += (_, e) =>
            HandleUnhandledException((Exception)e.ExceptionObject, "App");
        TaskScheduler.UnobservedTaskException += (_, e) =>
        {
            e.SetObserved();
            HandleUnhandledException(e.Exception, "Task");
        };
    }

    private void HandleUnhandledException(Exception exception, string category)
    {
        var logger = _loggerFactory.CreateLogger(category);
        logger.LogError(exception, "{Message}", exception.ToString());
        ExceptionWindow.Show(exception);
    }
}
