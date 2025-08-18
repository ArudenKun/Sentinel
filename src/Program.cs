using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Mvvm.Navigation;
using Sentinel.Views.Windows;
using Serilog;
using Wpf.Hosting;
using Wpf.Ui;
using Wpf.Ui.DependencyInjection;

namespace Sentinel;

public static class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        builder.AddWpfHost<App, MainWindow>();
        builder.Services.AddSerilog(configuration =>
            configuration.Enrich.FromLogContext().WriteTo.Async(c => c.Console())
        );
        builder.Services.AddMvvmNavigation();
        builder.Services.AddNavigationViewPageProvider();
        builder.Services.AddSingleton<IThemeService, ThemeService>();
        builder.Services.AddSingleton<ITaskBarService, TaskBarService>();
        builder.Services.AddSingleton<ISnackbarService, SnackbarService>();
        builder.Services.AddSingleton<IContentDialogService, ContentDialogService>();
        builder.Services.AddSingleton<INavigationService, NavigationService>();
        builder.Services.AddSingleton<INavigationWindow, MainWindow>();

        var app = builder.Build();

        try
        {
            app.Run();
        }
        catch (Exception e)
        {
            var logger = app.Services.GetRequiredService<ILogger<App>>();
            logger.LogError(e, "Global Unhandled exception");
            throw;
        }
        finally
        {
            app.Dispose();
        }
    }
}
