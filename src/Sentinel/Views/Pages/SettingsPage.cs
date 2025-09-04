using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Layout;
using Avalonia.Markup.Declarative;
using Lucide.Avalonia;
using Sentinel.Common.Extensions;
using Sentinel.Models;
using Sentinel.ViewModels.Pages;
using Sentinel.Views.Components;
using static Avalonia.Markup.Declarative.Builders;

namespace Sentinel.Views.Pages;

public class SettingsPage : View<SettingsPageViewModel>
{
    protected override object Build(SettingsPageViewModel vm) =>
        Grid()
            .Margin(24, 24, 0, 24)
            .Rows("Auto, *")
            .RowSpacing(12)
            .Children(
                TextBlock().Grid_Row(0).FontSize(26).Text("Settings"),
                TabControl()
                    .Grid_Row(1)
                    .Items(
                        TabItem()
                            .Header("User Interface")
                            .Content(
                                TabItemContent(
                                    new SettingsRow()
                                        .Title("Theme")
                                        .IconKind(LucideIconKind.SunMoon)
                                        .Content(
                                            ComboBox()
                                                .MinWidth(140)
                                                .VerticalAlignment(VerticalAlignment.Top)
                                                .ItemsSource(
                                                    vm.Settings.UI.Theme.GetType().GetAllValues()
                                                )
                                                .SelectedItem(
                                                    () => vm.Settings.UI.Theme,
                                                    theme => vm.Settings.UI.Theme = (Theme)theme
                                                )
                                        ),
                                    new SettingsRow()
                                        .Title("Language")
                                        .IconKind(LucideIconKind.Languages)
                                        .Content(ComboBox())
                                )
                            )
                    )
            );

    private static ScrollViewer TabItemContent(params Control[] children) =>
        ScrollViewer()
            .HorizontalScrollBarVisibility(ScrollBarVisibility.Auto)
            .Content(
                StackPanel()
                    .Margin(0, 12, 24)
                    .Orientation(Orientation.Vertical)
                    .Spacing(6)
                    .Children(children)
            );
}
