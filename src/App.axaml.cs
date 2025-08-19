using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sentinel.ViewModels;
using Sentinel.Views;
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

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var desktop = ApplicationLifetime;

        DisableAvaloniaDataAnnotationValidation();

        // desktop.ShutdownRequested += OnShutdownRequested;
        // desktop.Exit += OnExit;

        var services = new ServiceCollection();
        services.AddSingleton(desktop);
        // services.AddViews();
        // services.AddViewModels();
        services.AddSingleton<ViewLocator>();

        services.AddSingleton<TopLevel>(sp => sp.GetRequiredService<MainWindow>());
        services.AddSingleton(sp => sp.GetRequiredService<TopLevel>().Clipboard!);
        services.AddSingleton(sp => sp.GetRequiredService<TopLevel>().StorageProvider);

        // services.AddServices();
        // services.AddTransient(typeof(Lazy<>), typeof(LazyService<>));

        services.AddSingleton<ISukiDialogManager, SukiDialogManager>();
        services.AddSingleton<ISukiToastManager, SukiToastManager>();

        services.AddLogging(b => b.ClearProviders().AddSerilog(dispose: true));

        _serviceProvider = services.BuildServiceProvider();

        var viewLocator = _serviceProvider.GetRequiredService<ViewLocator>();
        DataTemplates.Add(viewLocator);

        var window =
            viewLocator.Build(_serviceProvider.GetRequiredService<MainWindowViewModel>()) as Window;
        desktop.MainWindow = window;

        base.OnFrameworkInitializationCompleted();
    }

    public object? GetService(Type serviceType)
    {
        return _serviceProvider?.GetService(serviceType);
    }

    public void Dispose()
    {
        if (_serviceProvider is null)
            return;

        _serviceProvider?.Dispose();
        _serviceProvider = null;
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
