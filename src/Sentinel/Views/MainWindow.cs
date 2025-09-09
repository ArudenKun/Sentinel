using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Layout;
using Avalonia.Markup.Declarative;
using Sentinel.Common.Helpers;
using Sentinel.ViewModels;
using SukiUI.Controls;
using static Avalonia.Markup.Declarative.Builders;

namespace Sentinel.Views;

public sealed class MainWindow : SukiWindow
{
    // public static FuncView<MainWindowViewModel> MainWindowTemplate(
    //     MainWindowViewModel mainWindowViewModel
    // ) =>
    //     new(
    //         mainWindowViewModel,
    //         vm =>
    //             new MainWindow()
    //                 .OnLoaded(_ => vm.OnLoaded())
    //                 .OnUnloaded(_ => vm.OnUnloaded())
    //                 .Title(AppHelper.Name)
    //                 .MinWidth(1366)
    //                 .MinHeight(768)
    //                 .BackgroundAnimationEnabled(() => vm.Settings.UI.BackgroundAnimations)
    //                 .BackgroundStyle(() => vm.Settings.UI.BackgroundStyle)
    //                 .BackgroundTransitionsEnabled(() => vm.Settings.UI.BackgroundTransitions)
    //                 .CanPin(false)
    //                 .Icon(AvaloniaResources.avalonia_logo_ico.AsWindowIcon())
    //                 .WindowStartupLocation(WindowStartupLocation.CenterScreen)
    //                 .WindowState(() => vm.Settings.UI.LastWindowState)
    //                 .LogoContent(
    //                     Image()
    //                         .Width(20)
    //                         .Height(20)
    //                         .VerticalAlignment(VerticalAlignment.Center)
    //                         .Source(AvaloniaResources.avalonia_logo_ico.AsBitmap())
    //                 )
    //                 .Hosts(
    //                     [
    //                         SukiDialogHost().Manager(vm.DialogManager),
    //                         SukiToastHost().Manager(vm.ToastManager),
    //                     ]
    //                 )
    //                 .Content(SukiTransitioningContentControl().Content(() => vm.ViewModel))
    //     );

    public static Window Build(MainWindowViewModel vm) =>
        new MainWindow()
            .OnLoaded(_ => vm.OnLoaded())
            .OnUnloaded(_ => vm.OnUnloaded())
            .Title(AppHelper.Name)
            .MinWidth(1366)
            .MinHeight(768)
            .BackgroundAnimationEnabled(vm.Settings.UI.BackgroundAnimations)
            .BackgroundStyle(vm.Settings.UI.BackgroundStyle, BindingMode.TwoWay)
            .BackgroundTransitionsEnabled(vm.Settings.UI.BackgroundTransitions, BindingMode.TwoWay)
            .CanPin(false)
            .Icon(AvaloniaResources.avalonia_logo_ico.AsWindowIcon())
            .WindowStartupLocation(WindowStartupLocation.CenterScreen)
            .WindowState(vm.Settings.UI.LastWindowState, BindingMode.TwoWay)
            .LogoContent(
                Image()
                    .Width(20)
                    .Height(20)
                    .VerticalAlignment(VerticalAlignment.Center)
                    .Source(AvaloniaResources.avalonia_logo_ico.AsBitmap())
            )
            .Hosts(
                [
                    SukiDialogHost().Manager(vm.DialogManager),
                    SukiToastHost().Manager(vm.ToastManager),
                ]
            )
            .Content(SukiTransitioningContentControl().Content(vm.ViewModel));
}
