using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Markup.Declarative;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Metadata;
using Avalonia.Styling;
using Lucide.Avalonia;
using static Avalonia.Markup.Declarative.Builders;

namespace Sentinel.Views.Components;

public sealed class SettingsRow : ComponentBase
{
    public static readonly StyledProperty<LucideIconKind?> IconKindProperty =
        AvaloniaProperty.Register<SettingsRow, LucideIconKind?>(nameof(IconKind));

    public LucideIconKind? IconKind
    {
        get => GetValue(IconKindProperty);
        set => SetValue(IconKindProperty, value);
    }

    public static readonly StyledProperty<string> TitleProperty = AvaloniaProperty.Register<
        SettingsRow,
        string
    >(nameof(Title), defaultValue: string.Empty);

    public string Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly StyledProperty<string> DescriptionProperty = AvaloniaProperty.Register<
        SettingsRow,
        string
    >(nameof(Description), defaultValue: string.Empty);

    public string Description
    {
        get => GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

    public static readonly StyledProperty<object?> ContentProperty = AvaloniaProperty.Register<
        SettingsRow,
        object?
    >(nameof(Content));

    [Content]
    public object? Content
    {
        get => GetValue(ContentProperty);
        set => SetValue(ContentProperty, value);
    }

    protected override StyleGroup BuildStyles() =>
        [
            Style<ToggleSwitch>(s => s.OfType<ToggleSwitch>())
                .MinWidth(0)
                .Height(36)
                .HorizontalContentAlignment(HorizontalAlignment.Right),
            Style<Slider>(s => s.OfType<Slider>()).MinWidth(140),
            Style<ComboBox>(s => s.OfType<ComboBox>()).MinWidth(140),
            Style<TextBox>(s => s.OfType<TextBox>()).MinWidth(140),
            Style<NumericUpDown>(s => s.OfType<NumericUpDown>()).MinWidth(140),
        ];

    protected override object Build() =>
        GlassCard()
            .HorizontalAlignment(HorizontalAlignment.Stretch)
            .MinWidth(148)
            .Height(72)
            .CornerRadius(new DynamicResourceExtension("ControlCornerRadius"))
            .BorderThickness(1)
            .Padding(16)
            .Content(
                Grid()
                    .HorizontalAlignment(HorizontalAlignment.Stretch)
                    .Cols("Auto,Auto,*,Auto")
                    .Children(
                        LucideIcon()
                            .Grid_Column(0)
                            .IsVisible(
                                IconKindProperty,
                                BindingMode.OneWay,
                                ObjectConverters.IsNotNull
                            )
                            .VerticalAlignment(VerticalAlignment.Center)
                            .Margin(2, 0, 20)
                            .Size(20)
                            .Kind(IconKindProperty, BindingMode.OneWay),
                        StackPanel()
                            .Grid_Column(1)
                            .VerticalAlignment(VerticalAlignment.Center)
                            .Orientation(Orientation.Vertical)
                            .Children(
                                TextBlock()
                                    .IsVisible(
                                        TitleProperty,
                                        BindingMode.OneWay,
                                        StringConverters.IsNotNullOrEmpty
                                    )
                                    .Foreground(new DynamicResourceExtension("SukiText"))
                                    .Text(TitleProperty, BindingMode.OneWay),
                                TextBlock()
                                    .IsVisible(
                                        DescriptionProperty,
                                        BindingMode.OneWay,
                                        StringConverters.IsNotNullOrEmpty
                                    )
                                    .FontSize(12)
                                    .Foreground(new DynamicResourceExtension("SukiLowText"))
                                    .Text(DescriptionProperty, BindingMode.OneWay)
                            ),
                        ContentControl()
                            .Grid_Column(3)
                            .HorizontalAlignment(HorizontalAlignment.Right)
                            .VerticalAlignment(VerticalAlignment.Center)
                            .Margin(12, 0, 0)
                            .HorizontalContentAlignment(HorizontalAlignment.Right)
                            .Content(ContentProperty, BindingMode.OneWay)
                    )
            );
    // GlassCard()
    //     .Height(72)
    //     .MinWidth(148)
    //     .Padding(16)
    //     .BorderThickness(1)
    //     .CornerRadius(new DynamicResourceExtension("ControlCornerRadius"))
    //     .Content(
    //         Grid()
    //             .HorizontalAlignment(HorizontalAlignment.Stretch)
    //             .Cols("Auto,Auto,*,Auto")
    //             .Children(
    //                 LucideIcon()
    //                     .Grid_Column(0)
    //                     .Margin(2, 0, 20)
    //                     .VerticalAlignment(VerticalAlignment.Center)
    //                     .IsVisible(
    //                         IconKindProperty,
    //                         BindingMode.OneWay,
    //                         ObjectConverters.IsNotNull
    //                     )
    //                     .Kind(IconKindProperty, BindingMode.OneWay)
    //                     .Size(20),
    //                 StackPanel()
    //                     .Grid_Column(1)
    //                     .VerticalAlignment(VerticalAlignment.Center)
    //                     .Orientation(Orientation.Vertical)
    //                     .Children(
    //                         TextBlock()
    //                             .Foreground(new DynamicResourceExtension("SukiText"))
    //                             .IsVisible(
    //                                 TitleProperty,
    //                                 BindingMode.OneWay,
    //                                 ObjectConverters.IsNotNull
    //                             )
    //                             .Text(TitleProperty, BindingMode.OneWay),
    //                         TextBlock()
    //                             .FontSize(12)
    //                             .Foreground(new DynamicResourceExtension("SukiLowText"))
    //                             .IsVisible(
    //                                 DescriptionProperty,
    //                                 BindingMode.OneWay,
    //                                 ObjectConverters.IsNotNull
    //                             )
    //                             .Text(DescriptionProperty, BindingMode.OneWay),
    //                         ContentControl()
    //                             .Grid_Column(3)
    //                             .Margin(12, 0, 0)
    //                             .HorizontalAlignment(HorizontalAlignment.Right)
    //                             .VerticalAlignment(VerticalAlignment.Center)
    //                             .HorizontalContentAlignment(HorizontalAlignment.Right)
    //                             .Content(ContentProperty)
    //                     )
    //             )
    //     );
}
