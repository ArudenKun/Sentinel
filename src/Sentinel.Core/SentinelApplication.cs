using Microsoft.Extensions.DependencyInjection;

namespace Sentinel.Core;

public class SentinelApplication
{
    public SentinelApplication(IServiceCollection services)
    {
        Services = services ?? throw new ArgumentNullException(nameof(services));
    }

    public IServiceCollection Services { get; }
}
