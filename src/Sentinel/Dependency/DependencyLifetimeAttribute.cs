using Microsoft.Extensions.DependencyInjection;

namespace Sentinel.Dependency;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class DependencyLifetimeAttribute : Attribute
{
    public DependencyLifetimeAttribute()
        : this(ServiceLifetime.Transient) { }

    public DependencyLifetimeAttribute(ServiceLifetime serviceLifetime)
    {
        ServiceLifetime = serviceLifetime;
    }

    public ServiceLifetime ServiceLifetime { get; }
}
