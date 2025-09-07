using System.ComponentModel;
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
                            .Header("UI")
                            .Content(
                                TabItemContent(
                                    new SettingsRow()
                                        .Title("Theme")
                                        .IconKind(LucideIconKind.SunMoon)
                                        .Content(
                                            ComboBox()
                                                .ItemsSource(vm.Settings.UI.Theme.GetAllValues())
                                                .SelectedItem(
                                                    () => vm.Settings.UI.Theme,
                                                    theme => vm.Settings.UI.Theme = (Theme)theme
                                                )
                                        ),
                                    new SettingsRow()
                                        .Title("Background Transitions")
                                        .IconKind(LucideIconKind.ArrowLeftRight)
                                        .Content(
                                            ToggleSwitch()
                                                .IsChecked(
                                                    () => vm.Settings.UI.BackgroundTransitions,
                                                    b =>
                                                        vm.Settings.UI.BackgroundTransitions =
                                                            b!.Value
                                                )
                                        )
                                )
                            ),
                        TabItem()
                            .Header("Database")
                            .Content(
                                TabItemContent(
                                    new SettingsRow()
                                        .Title("Type")
                                        .IconKind(LucideIconKind.Database)
                                        .Content(
                                            ComboBox()
                                                .ItemsSource(
                                                    vm.Settings.Database.Type.GetAllValues()
                                                )
                                                .SelectedItem(
                                                    () => vm.Settings.Database.Type,
                                                    type =>
                                                        vm.Settings.Database.Type =
                                                            (DatabaseType)type
                                                )
                                        ),
                                    new SettingsRow()
                                        .Title("Path")
                                        .Description("The path of the Sqlite Database")
                                        .IconKind(LucideIconKind.Lock)
                                        .Content(
                                            TextBox()
                                                .IsEnabled(
                                                    () =>
                                                        vm.Settings.Database.Type
                                                        == DatabaseType.Sqlite,
                                                    _ => RecomputeAllBindings()
                                                )
                                                .Text(() => vm.Settings.Database.ConnectionString)
                                        ),
                                    new SettingsRow()
                                        .Title("Connection String")
                                        .IconKind(LucideIconKind.Lock)
                                        .Content(
                                            TextBox()
                                                .IsEnabled(
                                                    () =>
                                                        vm.Settings.Database.Type
                                                        == DatabaseType.SqlServer,
                                                    _ => RecomputeAllBindings()
                                                )
                                                .Text("Placeholder")
                                        )
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
