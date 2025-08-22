using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sentinel.Dependency;
using Sentinel.ViewModels;
using Sentinel.ViewModels.Windows;

namespace Sentinel.Services;

public sealed class ViewModelProvider : ISingletonDependency
{
    private readonly ILogger<ViewModelProvider> _logger;
    private readonly IServiceProvider _serviceProvider;

    public ViewModelProvider(ILogger<ViewModelProvider> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    public TViewModel Create<TViewModel>()
        where TViewModel : ViewModel
    {
        _logger.LogInformation("Creating ViewModel {ViewModel}", typeof(TViewModel).Name);
        var viewModel = _serviceProvider.GetRequiredService<TViewModel>();
        _logger.LogInformation("Created {ViewModel}", typeof(TViewModel).Name);
        return viewModel;
    }

    public MainWindowViewModel CreateMainWindowViewModel() => Create<MainWindowViewModel>();

    public ExceptionWindowViewModel CreateExceptionWindowViewModel(Exception exception)
    {
        var viewModel = Create<ExceptionWindowViewModel>();
        viewModel.ExceptionObject = exception;
        viewModel.ExceptionType = exception.GetType().ToString();
        return viewModel;
    }
}
