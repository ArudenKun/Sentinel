using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Interactivity;
using Sentinel.Dependency;
using Sentinel.ViewModels;
using Sentinel.Views.Abstractions;
using ServiceScan.SourceGenerator;

namespace Sentinel.Services;

public sealed partial class ViewProvider : IDataTemplate, ISingletonDependency
{
    private readonly Dictionary<Type, Func<Control>> _viewFactory = new();
    private readonly Dictionary<Type, Control> _viewCache = new();

    public ViewProvider()
    {
        AddViews(this);
    }

    public TView CreateView<TView>(ViewModel viewModel)
        where TView : Control => (TView)CreateView(viewModel);

    public Control CreateView(ViewModel viewModel)
    {
        var viewModelType = viewModel.GetType();

        if (!_viewCache.TryGetValue(viewModelType, out var view))
        {
            if (!_viewFactory.TryGetValue(viewModelType, out var factory))
            {
                return CreateText($"Could not find view for {viewModelType.FullName}");
            }

            view = factory();
            _viewCache[viewModelType] = view;
        }

        view.DataContext = viewModel;
        BindEvents(view, viewModel);
        return view;
    }

    Control ITemplate<object?, Control?>.Build(object? data)
    {
        if (data is ViewModel viewModel)
        {
            return CreateView(viewModel);
        }

        return CreateText($"Could not find view for {data?.GetType().FullName}");
    }

    bool IDataTemplate.Match(object? data) => data is ViewModel;

    private static void BindEvents(Control control, ViewModel viewModel)
    {
        control.Loaded += Loaded;
        control.Unloaded += Unloaded;
        return;

        void Loaded(object? sender, RoutedEventArgs e) => viewModel.OnLoaded();

        void Unloaded(object? sender, RoutedEventArgs e)
        {
            viewModel.OnUnloaded();
            control.Loaded -= Loaded;
            control.Unloaded -= Unloaded;
        }
    }

    private static TextBlock CreateText(string text) => new() { Text = text };

    [GenerateServiceRegistrations(
        AssignableTo = typeof(IView<>),
        CustomHandler = nameof(AddViewsHandler)
    )]
    private static partial void AddViews(ViewProvider viewProvider);

    private static void AddViewsHandler<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TView,
        TViewModel
    >(ViewProvider viewProvider)
        where TView : Control, IView<TViewModel>, new()
        where TViewModel : ViewModel =>
        viewProvider._viewFactory.TryAdd(typeof(TViewModel), () => new TView());
}
