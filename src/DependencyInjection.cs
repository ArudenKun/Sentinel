using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using Avalonia.Controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Sentinel.Dependency;
using Sentinel.ViewModels;
using Sentinel.Views.Abstractions;
using ServiceScan.SourceGenerator;

namespace Sentinel;

public static partial class DependencyInjection
{
    [GenerateServiceRegistrations(
        AssignableTo = typeof(ISingletonDependency),
        AsSelf = true,
        AsImplementedInterfaces = true,
        Lifetime = ServiceLifetime.Singleton
    )]
    [GenerateServiceRegistrations(
        AssignableTo = typeof(ITransientDependency),
        AsSelf = true,
        AsImplementedInterfaces = true,
        Lifetime = ServiceLifetime.Transient
    )]
    public static partial IServiceCollection AddServices(this IServiceCollection services);

    [GenerateServiceRegistrations(
        AssignableTo = typeof(IView<>),
        CustomHandler = nameof(AddMvvmHandler)
    )]
    public static partial IServiceCollection AddMvvm(this IServiceCollection services);

    private static void AddMvvmHandler<
        TView,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TViewModel
    >(IServiceCollection services)
        where TView : Control, IView<TViewModel>
        where TViewModel : ViewModel
    {
        var viewType = typeof(TView);
        var viewModelType = typeof(TViewModel);
        var serviceLifetimeAttribute =
            viewModelType.GetCustomAttribute<ServiceLifetimeAttribute>()
            ?? new ServiceLifetimeAttribute();
        var viewSd = ServiceDescriptor.Describe(viewType, viewType, ServiceLifetime.Singleton);
        var viewModelSd = ServiceDescriptor.Describe(
            viewModelType,
            viewModelType,
            serviceLifetimeAttribute.Lifetime
        );
        var viewModelBasesSd = EnumerateBaseTypes<ViewModel>(viewModelType)
            .Select(baseType =>
                ServiceDescriptor.Describe(
                    baseType,
                    sp => sp.GetRequiredService<TViewModel>(),
                    serviceLifetimeAttribute.Lifetime
                )
            );
        services.Add(viewSd);
        services.Add(viewModelSd);
        services.Add(viewModelBasesSd);
    }

    private static IEnumerable<Type> EnumerateBaseTypes<TRoot>(Type t)
    {
        ArgumentNullException.ThrowIfNull(t);

        var baseType = t.BaseType;
        while (baseType is not null && baseType != typeof(object))
        {
            yield return baseType;
            if (baseType == typeof(TRoot))
            {
                yield break;
            }

            baseType = baseType.BaseType;
        }
    }
}
