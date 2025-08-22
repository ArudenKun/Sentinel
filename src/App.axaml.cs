using System;
using System.Linq;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using Flurl.Http.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using R3;
using Replicant;
using Sentinel.Common.Extensions;
using Sentinel.Common.Helpers;
using Sentinel.Configuration;
using Sentinel.Native;
using Sentinel.Services;
using Sentinel.Views.Windows;
using Serilog;
using SukiUI.Dialogs;
using SukiUI.Toasts;

namespace Sentinel;

public sealed class App : Application, IServiceProvider, IDisposable
{
    // ReSharper disable once ArrangeModifiersOrder
    public static new App Current =>
        (App?)Application.Current
        ?? throw new InvalidOperationException("Application is not yet initialized");

    // ReSharper disable once ArrangeModifiersOrder
    public static new IClassicDesktopStyleApplicationLifetime ApplicationLifetime =>
        (IClassicDesktopStyleApplicationLifetime?)Application.Current?.ApplicationLifetime
        ?? throw new InvalidOperationException("Application is not yet initialized");

    public static Window MainWindow =>
        ApplicationLifetime.MainWindow
        ?? throw new InvalidOperationException("Application is not yet initialized");

    private ServiceProvider? _serviceProvider;
    private Settings? _settings;

    public override void Initialize()
    {
        base.Initialize();

        LogHelper.Initialize();
        AvaloniaXamlLoader.Load(this);

        AppDomain.CurrentDomain.UnhandledException += (_, e) =>
            HandleUnhandledException((Exception)e.ExceptionObject, "App");
        TaskScheduler.UnobservedTaskException += (_, e) =>
        {
            e.SetObserved();
            HandleUnhandledException(e.Exception, "Task");
        };
        Dispatcher.UIThread.UnhandledException += (_, e) =>
        {
            e.Handled = true;
            HandleUnhandledException(e.Exception, "UI");
        };
        ObservableSystem.RegisterUnhandledExceptionHandler(exception =>
            HandleUnhandledException(exception, "UI R3")
        );
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var desktop = ApplicationLifetime;

        DisableAvaloniaDataAnnotationValidation();

        var services = new ServiceCollection();
        services.AddMvvm();
        services.AddServices();
        services.AddLogging(b => b.ClearProviders().AddSerilog(dispose: true));

        services.AddSingleton<TopLevel>(_ => MainWindow);
        services.AddSingleton(sp => sp.GetRequiredService<TopLevel>().StorageProvider);
        services.AddSingleton(sp => sp.GetRequiredService<TopLevel>().Clipboard!);
        services.AddSingleton(sp => sp.GetRequiredService<TopLevel>().Launcher);

        services.AddSingleton<ISukiDialogManager, SukiDialogManager>();
        services.AddSingleton<ISukiToastManager, SukiToastManager>();
        services.AddSingleton<IFlurlClientCache, FlurlClientCache>();
        services.AddTransient(typeof(Lazy<>), typeof(LazyProvider<>));
        services.AddSingleton<IHttpCache>(sp => new HttpCache(
            PathHelper.CacheDir,
            () => sp.GetRequiredService<IFlurlClientCache>().GetOrAdd("Replicant").HttpClient
        ));
        services.AddSingleton<INative, WindowsNative, MacOSNative, LinuxNative>();

        _serviceProvider = services.BuildServiceProvider(true);
        _settings = _serviceProvider.GetRequiredService<Settings>();

        var viewProvider = _serviceProvider.GetRequiredService<ViewProvider>();
        var viewModelProvider = _serviceProvider.GetRequiredService<ViewModelProvider>();
        DataTemplates.Add(viewProvider);

        desktop.MainWindow =
            viewProvider.CreateView(viewModelProvider.CreateMainWindowViewModel()) as Window;

        _settings.Load();

        base.OnFrameworkInitializationCompleted();
    }

    public object? GetService(Type serviceType) => _serviceProvider?.GetService(serviceType);

    public void Dispose()
    {
        _settings?.Save();
        _serviceProvider?.Dispose();
    }

    private void HandleUnhandledException(Exception ex, string category)
    {
        if (_serviceProvider is null)
            return;

        var loggerFactory = _serviceProvider.GetRequiredService<ILoggerFactory>();
        var logger = loggerFactory.CreateLogger(category);
        logger.LogError(ex, "Unhandled Exception");

        var viewProvider = _serviceProvider.GetRequiredService<ViewProvider>();
        var viewModelProvider = _serviceProvider.GetRequiredService<ViewModelProvider>();

        var exceptionWindow = viewProvider.CreateView<ExceptionWindow>(
            viewModelProvider.CreateExceptionWindowViewModel(ex)
        );
        DispatcherHelper.Invoke(() => exceptionWindow.ShowDialog(MainWindow));
    }

    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        var dataValidationPluginsToRemove = BindingPlugins
            .DataValidators.OfType<DataAnnotationsValidationPlugin>()
            .ToArray();

        // remove each entry found
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}
