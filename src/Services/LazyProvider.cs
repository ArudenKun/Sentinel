using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;

namespace Sentinel.Services;

public sealed class LazyProvider<
    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T
> : Lazy<T>
    where T : class
{
    public LazyProvider(IServiceProvider serviceProvider)
        : base(serviceProvider.GetRequiredService<T>, LazyThreadSafetyMode.ExecutionAndPublication)
    { }
}
