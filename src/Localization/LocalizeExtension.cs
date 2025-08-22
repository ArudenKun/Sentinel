using System;
using Avalonia;
using Avalonia.Markup.Xaml;
using R3;
using R3.ObservableEvents;

namespace Sentinel.Localization;

public class LocalizeExtension : MarkupExtension, IObservable<string>, IDisposable
{
    private readonly string _key;
    private Observer<string>? _observer;
    private IDisposable? _subscription;

    public LocalizeExtension(string key)
    {
        _key = key;
    }

    public IDisposable Subscribe(IObserver<string> observer)
    {
        _observer = observer.ToObserver();
        _observer.OnNext(Localizer.Get(_key));
        _subscription = Localizer
            .Instance.Events()
            .CultureChanged.Subscribe(_ => _observer?.OnNext(Localizer.Get(_key)));
        return this;
    }

    public override object ProvideValue(IServiceProvider serviceProvider) => this.ToBinding();

    public void Dispose()
    {
        _subscription?.Dispose();
        _observer = null;
        GC.SuppressFinalize(this);
    }
}
