﻿using Avalonia.Threading;
using Sentinel.Common.Extensions;

namespace Sentinel.Common.Helpers;

public static class DispatchHelper
{
    /// <inheritdoc cref="Dispatcher.Invoke(Action, DispatcherPriority)"/>>
    public static void Invoke(Action callback, DispatcherPriority? priority = null)
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            callback();
            return;
        }

        Dispatcher.UIThread.Invoke(callback, priority ?? DispatcherPriority.Send);
    }

    /// <inheritdoc cref="Dispatcher.Invoke{TResult}(Func{TResult}, DispatcherPriority)"/>>
    public static TResult Invoke<TResult>(
        Func<TResult> callback,
        DispatcherPriority? priority = null
    ) =>
        Dispatcher.UIThread.CheckAccess()
            ? callback()
            : Dispatcher.UIThread.Invoke(callback, priority ?? DispatcherPriority.Send);

    /// <inheritdoc cref="Dispatcher.InvokeAsync(Func{Task}, DispatcherPriority)"/>>
    public static async Task InvokeAsync(Func<Task> func, DispatcherPriority? priority = null)
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            await func();
            return;
        }

        await Dispatcher.UIThread.InvokeAsync(func, priority ?? DispatcherPriority.Default);
    }

    /// <inheritdoc cref="Dispatcher.InvokeAsync{TResult}(Func{Task{TResult}}, DispatcherPriority)"/>
    public static async Task<TResult> InvokeAsync<TResult>(
        Func<Task<TResult>> callback,
        DispatcherPriority? priority = null
    )
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            return await callback();
        }

        return await Dispatcher.UIThread.InvokeAsync(
            callback,
            priority ?? DispatcherPriority.Default
        );
    }

    /// <inheritdoc cref="Dispatcher.Post(Action, DispatcherPriority)"/>>
    public static void Post(Action callback, DispatcherPriority priority = default) =>
        Dispatcher.UIThread.Post(callback, priority);

    /// <inheritdoc cref="Dispatcher.Post(Action,DispatcherPriority)"/>>
    public static async Task PostAsync(Func<Task> callback) =>
        await Dispatcher.UIThread.PostAsync(callback);

    public static void RunTimer(
        Func<bool> cb,
        TimeSpan interval,
        DispatcherPriority priority = default
    ) => DispatcherTimer.Run(cb, interval, priority);

    public static void RunTimerOnce(
        Action cb,
        TimeSpan interval,
        DispatcherPriority priority = default
    ) => DispatcherTimer.RunOnce(cb, interval, priority);
}
