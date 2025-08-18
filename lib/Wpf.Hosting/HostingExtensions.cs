using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wpf.Hosting.Internal;
using Wpf.Hosting.Services;

namespace Wpf.Hosting;

/// <summary>
/// Provides extension methods for configuring Wpf applications with the generic host.
/// </summary>
public static class HostingExtensions
{
    private const string MutexBuilderKey = "MutexBuilder-3BEF5C0B-DDC9-41E3-97E5-43DD8D761BB3";

    /// <summary>
    /// Adds Wpf application and main window to the host's service collection.
    /// </summary>
    /// <typeparam name="TApplication">The type of the Wpf application.</typeparam>
    /// <typeparam name="TWindow">The type of the main window.</typeparam>
    /// <param name="builder">The host application builder.</param>
    /// <returns>The updated host application builder.</returns>
    public static IHostApplicationBuilder AddWpfHost<TApplication, TWindow>(
        this IHostApplicationBuilder builder
    )
        where TApplication : Application
        where TWindow : Window
    {
        builder.Services.AddSingleton<Application, TApplication>();
        builder.Services.AddSingleton<Window, TWindow>();
        builder.Services.AddSingleton<WpfThread>();
        builder.Services.AddHostedService<WpfHostedService>();

        return builder;
    }

    /// <summary>
    /// Prevent that an application runs multiple times
    /// </summary>
    /// <param name="builder">IHostBuilder</param>
    /// <param name="configure">Action to configure IMutexBuilder</param>
    /// <returns>IHostApplicationBuilder for fluently calling</returns>
    public static IHostApplicationBuilder AddSingleInstance(
        this IHostApplicationBuilder builder,
        Action<IMutexBuilder>? configure = null
    )
    {
        if (!TryRetrieveMutexBuilder(builder.Properties, out var mutexBuilder))
        {
            builder.Services.AddSingleton(mutexBuilder).AddHostedService<MutexHostedService>();
        }

        configure?.Invoke(mutexBuilder);

        return builder;
    }

    /// <summary>
    /// Prevent that an application runs multiple times
    /// </summary>
    /// <param name="hostBuilder">IHostBuilder</param>
    /// <param name="mutexId">The Mutex Id</param>
    /// <returns>IHostApplicationBuilder for fluently calling</returns>
    public static IHostApplicationBuilder AddSingleInstance(
        this IHostApplicationBuilder hostBuilder,
        string mutexId
    ) => hostBuilder.AddSingleInstance(builder => builder.MutexId = mutexId);

    /// <summary>
    /// Helper method to retrieve the mutex builder
    /// </summary>
    /// <param name="properties">IDictionary</param>
    /// <param name="mutexBuilder">IMutexBuilder out value</param>
    /// <returns>bool if there was a matcher</returns>
    private static bool TryRetrieveMutexBuilder(
        this IDictionary<object, object> properties,
        out IMutexBuilder mutexBuilder
    )
    {
        if (properties.TryGetValue(MutexBuilderKey, out var mutexBuilderObject))
        {
            mutexBuilder = (IMutexBuilder)mutexBuilderObject;
            return true;
        }

        mutexBuilder = new MutexBuilder();
        properties[MutexBuilderKey] = mutexBuilder;
        return false;
    }
}
