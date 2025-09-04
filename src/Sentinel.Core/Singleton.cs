namespace Sentinel.Core;

public abstract class Singleton<TSelf>
    where TSelf : Singleton<TSelf>, new()
{
    private static readonly Lazy<TSelf> Lazy = new(
        () => new TSelf(),
        LazyThreadSafetyMode.ExecutionAndPublication
    );

    public static TSelf Instance => Lazy.Value;
}
