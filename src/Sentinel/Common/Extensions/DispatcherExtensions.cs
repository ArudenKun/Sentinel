using Avalonia.Threading;

namespace Sentinel.Common.Extensions;

public static class DispatcherExtensions
{
    public static Task<T> PostAsync<T>(
        this IDispatcher dispatcher,
        Func<T> action,
        DispatcherPriority dispatcherPriority = default
    )
    {
        var tcs = new TaskCompletionSource<T>();
        dispatcher.Post(() => tcs.SetResult(action()), dispatcherPriority);
        return tcs.Task;
    }
}
