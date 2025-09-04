using System.Diagnostics.CodeAnalysis;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Sentinel.Dependency;
using Sentinel.ViewModels;
using Sentinel.Views;
using ServiceScan.SourceGenerator;

namespace Sentinel;

public sealed partial class ViewLocator : IDataTemplate, ISingletonDependency
{
    private readonly Dictionary<Type, Func<Control>> _viewFactory = new();
    private readonly Dictionary<Type, Control> _viewCache = new();

    public ViewLocator()
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

            _viewCache[viewModelType] = view = factory();
        }

        view.DataContext = viewModel;
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

    private static TextBlock CreateText(string text) => new() { Text = text };

    [GenerateServiceRegistrations(
        AssignableTo = typeof(View<>),
        CustomHandler = nameof(AddViewsHandler)
    )]
    private static partial void AddViews(ViewLocator viewLocator);

    private static void AddViewsHandler<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TView,
        TViewModel
    >(ViewLocator viewLocator)
        where TView : View<TViewModel>, new()
        where TViewModel : ViewModel =>
        viewLocator._viewFactory.TryAdd(typeof(TViewModel), () => new TView());
}
