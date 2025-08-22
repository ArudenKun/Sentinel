using System;
using System.Threading.Tasks;
using Avalonia.Threading;
using Sentinel.Common.Extensions;

namespace Sentinel.Common.Helpers;

public static class DispatcherHelper
{
    /// <inheritdoc cref="Dispatcher.Invoke(Action)"/>>
    public static void Invoke(Action callback)
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            callback();
            return;
        }

        Dispatcher.UIThread.Invoke(callback);
    }

    /// <inheritdoc cref="Dispatcher.Invoke(Func{TResult})"/>>
    public static TResult Invoke<TResult>(Func<TResult> callback) =>
        Dispatcher.UIThread.CheckAccess() ? callback() : Dispatcher.UIThread.Invoke(callback);

    /// <inheritdoc cref="Dispatcher.InvokeAsync(Func{Task})"/>>
    public static async Task InvokeAsync(Func<Task> func)
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            await func();
            return;
        }

        await Dispatcher.UIThread.InvokeAsync(func);
    }

    /// <inheritdoc cref="Dispatcher.InvokeAsync(Func{Task{TResult}})"/>>
    public static async Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> callback)
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            return await callback();
        }

        return await Dispatcher.UIThread.InvokeAsync(callback);
    }

    /// <inheritdoc cref="Dispatcher.Post(Action)"/>>
    public static void Post(Action callback) => Dispatcher.UIThread.Post(callback);

    /// <inheritdoc cref="Dispatcher.Post(Action)"/>>
    public static async Task PostAsync(Func<Task> callback) =>
        await Dispatcher.UIThread.PostAsync(callback);
}
