using System;
using Microsoft.Extensions.DependencyInjection;

namespace Sentinel.Common.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSingleton<
        TService,
        TWindowsImplementation,
        TMacImplementation,
        TLinuxImplementation
    >(this IServiceCollection services)
        where TWindowsImplementation : TService
        where TMacImplementation : TService
        where TLinuxImplementation : TService =>
        services.Add(
            typeof(TService),
            typeof(TWindowsImplementation),
            typeof(TMacImplementation),
            typeof(TLinuxImplementation),
            ServiceLifetime.Singleton
        );

    public static IServiceCollection AddSingleton<
        TService,
        TWindowsImplementation,
        TMacImplementation,
        TLinuxImplementation
    >(
        this IServiceCollection services,
        Func<IServiceProvider, TWindowsImplementation>? windowsImplementationFactory,
        Func<IServiceProvider, TMacImplementation>? macImplementationFactory,
        Func<IServiceProvider, TLinuxImplementation>? linuxImplementationFactory
    )
        where TWindowsImplementation : TService
        where TMacImplementation : TService
        where TLinuxImplementation : TService =>
        Add(
            services,
            typeof(TService),
            windowsImplementationFactory is null ? null : sp => windowsImplementationFactory(sp)!,
            macImplementationFactory is null ? null : sp => macImplementationFactory(sp)!,
            linuxImplementationFactory is null ? null : sp => linuxImplementationFactory(sp)!,
            ServiceLifetime.Singleton
        );

    public static IServiceCollection AddTransient<
        TService,
        TWindowsImplementation,
        TMacImplementation,
        TLinuxImplementation
    >(this IServiceCollection services)
        where TWindowsImplementation : TService
        where TMacImplementation : TService
        where TLinuxImplementation : TService =>
        services.Add(
            typeof(TService),
            typeof(TWindowsImplementation),
            typeof(TMacImplementation),
            typeof(TLinuxImplementation),
            ServiceLifetime.Transient
        );

    public static IServiceCollection AddTransient<
        TService,
        TWindowsImplementation,
        TMacImplementation,
        TLinuxImplementation
    >(
        this IServiceCollection services,
        Func<IServiceProvider, TWindowsImplementation>? windowsImplementationFactory,
        Func<IServiceProvider, TMacImplementation>? macImplementationFactory,
        Func<IServiceProvider, TLinuxImplementation>? linuxImplementationFactory
    )
        where TWindowsImplementation : TService
        where TMacImplementation : TService
        where TLinuxImplementation : TService =>
        Add(
            services,
            typeof(TService),
            windowsImplementationFactory is null ? null : sp => windowsImplementationFactory(sp)!,
            macImplementationFactory is null ? null : sp => macImplementationFactory(sp)!,
            linuxImplementationFactory is null ? null : sp => linuxImplementationFactory(sp)!,
            ServiceLifetime.Transient
        );

    public static IServiceCollection AddScoped<
        TService,
        TWindowsImplementation,
        TMacImplementation,
        TLinuxImplementation
    >(this IServiceCollection services)
        where TWindowsImplementation : TService
        where TMacImplementation : TService
        where TLinuxImplementation : TService =>
        services.Add(
            typeof(TService),
            typeof(TWindowsImplementation),
            typeof(TMacImplementation),
            typeof(TLinuxImplementation),
            ServiceLifetime.Scoped
        );

    public static IServiceCollection AddScoped<
        TService,
        TWindowsImplementation,
        TMacImplementation,
        TLinuxImplementation
    >(
        this IServiceCollection services,
        Func<IServiceProvider, TWindowsImplementation>? windowsImplementationFactory,
        Func<IServiceProvider, TMacImplementation>? macImplementationFactory,
        Func<IServiceProvider, TLinuxImplementation>? linuxImplementationFactory
    )
        where TWindowsImplementation : TService
        where TMacImplementation : TService
        where TLinuxImplementation : TService =>
        Add(
            services,
            typeof(TService),
            windowsImplementationFactory is null ? null : sp => windowsImplementationFactory(sp)!,
            macImplementationFactory is null ? null : sp => macImplementationFactory(sp)!,
            linuxImplementationFactory is null ? null : sp => linuxImplementationFactory(sp)!,
            ServiceLifetime.Scoped
        );

    private static IServiceCollection Add(
        this IServiceCollection services,
        Type serviceType,
        Type? windowsImplementation,
        Type? macImplementation,
        Type? linuxImplementation,
        ServiceLifetime lifetime
    )
    {
        if (OperatingSystem.IsWindows() && windowsImplementation is not null)
        {
            services.Add(ServiceDescriptor.Describe(serviceType, windowsImplementation, lifetime));
        }
        else if (OperatingSystem.IsMacOS() && macImplementation is not null)
        {
            services.Add(ServiceDescriptor.Describe(serviceType, macImplementation, lifetime));
        }
        else if (OperatingSystem.IsLinux() && linuxImplementation is not null)
        {
            services.Add(ServiceDescriptor.Describe(serviceType, linuxImplementation, lifetime));
        }
        else
        {
            throw new PlatformNotSupportedException("This platform is not supported.");
        }

        return services;
    }

    private static IServiceCollection Add(
        this IServiceCollection services,
        Type serviceType,
        Func<IServiceProvider, object>? windowsImplementationFactory,
        Func<IServiceProvider, object>? macImplementationFactory,
        Func<IServiceProvider, object>? linuxImplementationFactory,
        ServiceLifetime lifetime
    )
    {
        if (OperatingSystem.IsWindows() && windowsImplementationFactory is not null)
        {
            services.Add(
                ServiceDescriptor.Describe(serviceType, windowsImplementationFactory, lifetime)
            );
        }
        else if (OperatingSystem.IsMacOS() && macImplementationFactory is not null)
        {
            services.Add(
                ServiceDescriptor.Describe(serviceType, macImplementationFactory, lifetime)
            );
        }
        else if (OperatingSystem.IsLinux() && linuxImplementationFactory is not null)
        {
            services.Add(
                ServiceDescriptor.Describe(serviceType, linuxImplementationFactory, lifetime)
            );
        }
        else
        {
            throw new PlatformNotSupportedException("This platform is not supported.");
        }

        return services;
    }
}
