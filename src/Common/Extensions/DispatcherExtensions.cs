using System;
using System.Threading.Tasks;
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
        var completion = new TaskCompletionSource<T>();
        dispatcher.Post(() => completion.SetResult(action()), dispatcherPriority);
        return completion.Task;
    }
}
