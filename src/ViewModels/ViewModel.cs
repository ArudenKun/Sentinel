using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Sentinel.Configuration;
using Sentinel.Native;

namespace Sentinel.ViewModels;

public abstract class ViewModel : ObservableRecipient, IDisposable
{
    private bool _isDisposed;

    public Settings Settings => App.Current.GetRequiredService<Lazy<Settings>>().Value;

    public INative Native => App.Current.GetRequiredService<Lazy<INative>>().Value;

    public TopLevel TopLevel => App.Current.GetRequiredService<Lazy<TopLevel>>().Value;

    public virtual void OnLoaded() { }

    public virtual void OnUnloaded() { }

    protected void OnAllPropertiesChanged() => OnPropertyChanged(string.Empty);

    ~ViewModel() => Dispose(false);

    private List<Action?>? _onDisposeActions;

    public void OnDispose(Action? callback = null)
    {
        _onDisposeActions ??= [];
        _onDisposeActions.Add(callback);
    }

    /// <inheritdoc cref="Dispose"/>>
    protected virtual void Dispose(bool disposing)
    {
        if (_isDisposed)
            return;

        if (!disposing)
            return;

        if (_onDisposeActions is { Count: > 0 })
        {
            foreach (var disposeAction in _onDisposeActions.Distinct())
            {
                disposeAction?.Invoke();
            }
        }

        _isDisposed = true;
    }

    /// <inheritdoc />>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
