#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class SukiSideMenu_MarkupExtensions
{
//================= Properties ======================//
 // SearchText

/*ValueSetterGenerator*/
public static T SearchText<T>(this T control, System.String value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.SearchText = value!);

/*BindFromExpressionSetterGenerator*/
public static T SearchText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.SearchTextProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SearchText<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.SearchTextProperty, ps, () => control.SearchText = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SearchText<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.SearchTextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SearchText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.SearchTextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SearchText<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.SearchTextProperty, ps, () => control.SearchText = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsSearchEnabled

/*ValueSetterGenerator*/
public static T IsSearchEnabled<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.IsSearchEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsSearchEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsSearchEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsSearchEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.IsSearchEnabledProperty, ps, () => control.IsSearchEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsSearchEnabled<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsSearchEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSearchEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsSearchEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsSearchEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.IsSearchEnabledProperty, ps, () => control.IsSearchEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsContentVisible

/*ValueSetterGenerator*/
public static T IsContentVisible<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.IsContentVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsContentVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsContentVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsContentVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.IsContentVisibleProperty, ps, () => control.IsContentVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsContentVisible<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsContentVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsContentVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsContentVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsContentVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.IsContentVisibleProperty, ps, () => control.IsContentVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SidebarToggleEnabled

/*ValueSetterGenerator*/
public static T SidebarToggleEnabled<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.SidebarToggleEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T SidebarToggleEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.SidebarToggleEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SidebarToggleEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.SidebarToggleEnabledProperty, ps, () => control.SidebarToggleEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SidebarToggleEnabled<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.SidebarToggleEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SidebarToggleEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.SidebarToggleEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SidebarToggleEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.SidebarToggleEnabledProperty, ps, () => control.SidebarToggleEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsToggleButtonVisible

/*ValueSetterGenerator*/
public static T IsToggleButtonVisible<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.IsToggleButtonVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsToggleButtonVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsToggleButtonVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsToggleButtonVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.IsToggleButtonVisibleProperty, ps, () => control.IsToggleButtonVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsToggleButtonVisible<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsToggleButtonVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsToggleButtonVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsToggleButtonVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsToggleButtonVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.IsToggleButtonVisibleProperty, ps, () => control.IsToggleButtonVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsMenuExpanded

/*ValueSetterGenerator*/
public static T IsMenuExpanded<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.IsMenuExpanded = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsMenuExpanded<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsMenuExpandedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsMenuExpanded<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.IsMenuExpandedProperty, ps, () => control.IsMenuExpanded = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsMenuExpanded<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsMenuExpandedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsMenuExpanded<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsMenuExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsMenuExpanded<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.IsMenuExpandedProperty, ps, () => control.IsMenuExpanded = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // OpenPaneLength

/*ValueSetterGenerator*/
public static T OpenPaneLength<T>(this T control, System.Int32 value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.OpenPaneLength = value!);

/*BindFromExpressionSetterGenerator*/
public static T OpenPaneLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.OpenPaneLengthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T OpenPaneLength<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OpenPaneLength<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.OpenPaneLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OpenPaneLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.OpenPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T OpenPaneLength<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TogglePaneButtonPosition

/*ValueSetterGenerator*/
public static T TogglePaneButtonPosition<T>(this T control, SukiUI.Enums.SideMenuTogglePaneButtonPositionOptions value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.TogglePaneButtonPosition = value!);

/*BindFromExpressionSetterGenerator*/
public static T TogglePaneButtonPosition<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.TogglePaneButtonPositionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TogglePaneButtonPosition<T>(this T control,SukiUI.Enums.SideMenuTogglePaneButtonPositionOptions value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.TogglePaneButtonPositionProperty, ps, () => control.TogglePaneButtonPosition = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TogglePaneButtonPosition<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.TogglePaneButtonPositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TogglePaneButtonPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.TogglePaneButtonPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TogglePaneButtonPosition<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Enums.SideMenuTogglePaneButtonPositionOptions> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.TogglePaneButtonPositionProperty, ps, () => control.TogglePaneButtonPosition = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsSelectedItemContentMovable

/*ValueSetterGenerator*/
public static T IsSelectedItemContentMovable<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.IsSelectedItemContentMovable = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsSelectedItemContentMovable<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsSelectedItemContentMovableProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsSelectedItemContentMovable<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.IsSelectedItemContentMovableProperty, ps, () => control.IsSelectedItemContentMovable = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsSelectedItemContentMovable<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsSelectedItemContentMovableProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSelectedItemContentMovable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.IsSelectedItemContentMovableProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsSelectedItemContentMovable<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.IsSelectedItemContentMovableProperty, ps, () => control.IsSelectedItemContentMovable = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HeaderMinHeight

/*ValueSetterGenerator*/
public static T HeaderMinHeight<T>(this T control, System.Double value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.HeaderMinHeight = value!);

/*BindFromExpressionSetterGenerator*/
public static T HeaderMinHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.HeaderMinHeightProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HeaderMinHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.HeaderMinHeightProperty, ps, () => control.HeaderMinHeight = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HeaderMinHeight<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.HeaderMinHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HeaderMinHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.HeaderMinHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HeaderMinHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.HeaderMinHeightProperty, ps, () => control.HeaderMinHeight = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HeaderContent

/*ValueSetterGenerator*/
public static T HeaderContent<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.HeaderContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T HeaderContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.HeaderContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HeaderContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.HeaderContentProperty, ps, () => control.HeaderContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HeaderContent<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.HeaderContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HeaderContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.HeaderContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HeaderContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.HeaderContentProperty, ps, () => control.HeaderContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // FooterContent

/*ValueSetterGenerator*/
public static T FooterContent<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.FooterContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T FooterContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.FooterContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T FooterContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.FooterContentProperty, ps, () => control.FooterContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FooterContent<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.FooterContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FooterContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.FooterContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T FooterContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.FooterContentProperty, ps, () => control.FooterContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.Content = value!);

/*BindFromExpressionSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.ContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Content<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.ContentProperty, ps, () => control.Content = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Content<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.ContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Content<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.ContentProperty, ps, () => control.Content = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UseCustomContent

/*ValueSetterGenerator*/
public static T UseCustomContent<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> control._set(() => control.UseCustomContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T UseCustomContent<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.UseCustomContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UseCustomContent<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.UseCustomContentProperty, ps, () => control.UseCustomContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UseCustomContent<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.UseCustomContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseCustomContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenu 
   => control._set(SukiUI.Controls.SukiSideMenu.UseCustomContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UseCustomContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenu 
=> control._setEx(SukiUI.Controls.SukiSideMenu.UseCustomContentProperty, ps, () => control.UseCustomContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // SearchText

/*ValueStyleSetterGenerator*/
public static Style<T> SearchText<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.SearchTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SearchText<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.SearchTextProperty, binding);


 // IsSearchEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsSearchEnabled<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.IsSearchEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSearchEnabled<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.IsSearchEnabledProperty, binding);


 // IsContentVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsContentVisible<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.IsContentVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsContentVisible<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.IsContentVisibleProperty, binding);


 // SidebarToggleEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> SidebarToggleEnabled<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.SidebarToggleEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SidebarToggleEnabled<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.SidebarToggleEnabledProperty, binding);


 // IsToggleButtonVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsToggleButtonVisible<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.IsToggleButtonVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsToggleButtonVisible<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.IsToggleButtonVisibleProperty, binding);


 // IsMenuExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsMenuExpanded<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.IsMenuExpandedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsMenuExpanded<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.IsMenuExpandedProperty, binding);


 // OpenPaneLength

/*ValueStyleSetterGenerator*/
public static Style<T> OpenPaneLength<T>(this Style<T> style, System.Int32 value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.OpenPaneLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OpenPaneLength<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.OpenPaneLengthProperty, binding);


 // TogglePaneButtonPosition

/*ValueStyleSetterGenerator*/
public static Style<T> TogglePaneButtonPosition<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.TogglePaneButtonPositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TogglePaneButtonPosition<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.TogglePaneButtonPositionProperty, binding);


 // IsSelectedItemContentMovable

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelectedItemContentMovable<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.IsSelectedItemContentMovableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelectedItemContentMovable<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.IsSelectedItemContentMovableProperty, binding);


 // HeaderMinHeight

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderMinHeight<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.HeaderMinHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HeaderMinHeight<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.HeaderMinHeightProperty, binding);


 // HeaderContent

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderContent<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.HeaderContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HeaderContent<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.HeaderContentProperty, binding);


 // FooterContent

/*ValueStyleSetterGenerator*/
public static Style<T> FooterContent<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.FooterContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FooterContent<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.FooterContentProperty, binding);


 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.ContentProperty, binding);


 // UseCustomContent

/*ValueStyleSetterGenerator*/
public static Style<T> UseCustomContent<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.UseCustomContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseCustomContent<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenu 
=> style._addSetter(SukiUI.Controls.SukiSideMenu.UseCustomContentProperty, binding);



}
