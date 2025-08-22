using System;
using Microsoft.Extensions.DependencyInjection;

namespace Sentinel.Dependency;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class ServiceLifetimeAttribute : Attribute
{
    public ServiceLifetimeAttribute(ServiceLifetime lifetime = ServiceLifetime.Transient)
    {
        Lifetime = lifetime;
    }

    public ServiceLifetime Lifetime { get; }
}
