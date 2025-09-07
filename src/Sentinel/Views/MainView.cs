using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Layout;
using Avalonia.Markup.Declarative;
using Avalonia.Styling;
using Lucide.Avalonia;
using Sentinel.ViewModels;
using Sentinel.ViewModels.Pages;
using static Avalonia.Markup.Declarative.Builders;

namespace Sentinel.Views;

public class MainView : View<MainViewModel>
{
    protected override object Build(MainViewModel vm) =>
        SukiSideMenu()
            .Styles(Style<Image>(s => s.Class("AppIcon").Descendant()).Opacity(0.5))
            .IsMenuExpanded(vm.Settings.UI.IsSideMenuExpanded)
            .IsSearchEnabled(false)
            .ItemsSource(vm.Pages)
            .SelectedItem(() => vm.Page, page => vm.Page = (PageViewModel)page)
            .ItemTemplate(
                new FuncDataTemplate<PageViewModel>(
                    (pvm, _) =>
                        SukiSideMenuItem()
                            .Classes("Compact")
                            .Header(pvm.DisplayName)
                            .IsVisible(pvm.IsVisibleOnSideMenu)
                            .Icon(LucideIcon().Kind(pvm.IconKind))
                )
            )
            .HeaderContent(
                Image()
                    .Width(80)
                    .Height(80)
                    .Margin(30, 10, 30, 30)
                    .Classes("AppIcon")
                    .Source(AvaloniaResources.avalonia_logo_ico.AsBitmap())
                    .ToolTip_Tip("Click To Toggle Top Menu")
            )
            .FooterContent(
                StackPanel()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Orientation(Orientation.Horizontal)
                    .Spacing(5)
                    .Children(
                        Button()
                            .Classes("Icon")
                            .Command(vm.ShowSettingsCommand)
                            .Content(LucideIcon().Kind(LucideIconKind.Cog).Size(25))
                    )
            );
}
