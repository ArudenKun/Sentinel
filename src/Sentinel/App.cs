using System.Diagnostics.CodeAnalysis;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Microsoft.Extensions.DependencyInjection;
using Sentinel.Common.Helpers;
using Sentinel.Services;
using Sentinel.ViewModels;
using Sentinel.Views;
using SukiUI;
using SukiUI.Enums;

namespace Sentinel;

public sealed class App : Application, IDisposable
{
    private static readonly Lazy<IServiceProvider> LazyServiceProvider = new(
        () =>
            new ServiceCollection()
                .AddViewModels()
                .AddServices()
                .AddScannedServices()
                .AddSerilog()
                .BuildServiceProvider(true),
        LazyThreadSafetyMode.ExecutionAndPublication
    );

    private static IServiceProvider ServiceProvider => LazyServiceProvider.Value;

    // ReSharper disable once ArrangeModifiersOrder
    public static new App Current =>
        (App?)Application.Current
        ?? throw new ArgumentNullException(
            nameof(Application.Current),
            "Application is not yet initialized"
        );

    [field: MaybeNull]
    public static TopLevel TopLevel
    {
        get =>
            field
            ?? throw new ArgumentNullException(
                nameof(Application.Current),
                "Application is not yet initialized"
            );
        private set;
    }

    public static T? GetService<T>()
        where T : notnull => ServiceProvider.GetService<T>();

    public static object? GetService(Type type) => ServiceProvider.GetService(type);

    public static T GetRequiredService<T>()
        where T : notnull => ServiceProvider.GetRequiredService<T>();

    public static object GetRequiredService(Type type) => ServiceProvider.GetRequiredService(type);

    public void Dispose()
    {
        if (ServiceProvider is IDisposable disposable)
        {
            disposable.Dispose();
        }
        LogHelper.Cleanup();
    }

    public override void Initialize()
    {
#if DEBUG
        this.AttachDevTools();
#endif
        Styles.Add(new SukiTheme { ThemeColor = SukiColor.Blue });
        DataTemplates.Add(GetRequiredService<ViewLocator>());

        LogHelper.Initialize();
        GetRequiredService<ThemeService>().Initialize();
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is not IClassicDesktopStyleApplicationLifetime desktop)
            return;

        DisableAvaloniaDataAnnotationValidation();

        var mainWindow = MainWindow.Build(GetRequiredService<MainWindowViewModel>());
        desktop.MainWindow = mainWindow;
        TopLevel = TopLevel.GetTopLevel(desktop.MainWindow)!;

        base.OnFrameworkInitializationCompleted();
    }

    // Avoid duplicate validations from both Avalonia and the CommunityToolkit.
    // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
    private static void DisableAvaloniaDataAnnotationValidation()
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
