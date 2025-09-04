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
public static partial class SukiWindow_MarkupExtensions
{
//================= Properties ======================//
 // MaxWidthScreenRatio

/*ValueSetterGenerator*/
public static T MaxWidthScreenRatio<T>(this T control, System.Double value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.MaxWidthScreenRatio = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxWidthScreenRatio<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.MaxWidthScreenRatioProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxWidthScreenRatio<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.MaxWidthScreenRatioProperty, ps, () => control.MaxWidthScreenRatio = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxWidthScreenRatio<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.MaxWidthScreenRatioProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxWidthScreenRatio<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.MaxWidthScreenRatioProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxWidthScreenRatio<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.MaxWidthScreenRatioProperty, ps, () => control.MaxWidthScreenRatio = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxHeightScreenRatio

/*ValueSetterGenerator*/
public static T MaxHeightScreenRatio<T>(this T control, System.Double value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.MaxHeightScreenRatio = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxHeightScreenRatio<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.MaxHeightScreenRatioProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxHeightScreenRatio<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.MaxHeightScreenRatioProperty, ps, () => control.MaxHeightScreenRatio = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxHeightScreenRatio<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.MaxHeightScreenRatioProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxHeightScreenRatio<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.MaxHeightScreenRatioProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxHeightScreenRatio<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.MaxHeightScreenRatioProperty, ps, () => control.MaxHeightScreenRatio = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsTitleBarVisible

/*ValueSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.IsTitleBarVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.IsTitleBarVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsTitleBarVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.IsTitleBarVisibleProperty, ps, () => control.IsTitleBarVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.IsTitleBarVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.IsTitleBarVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsTitleBarVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.IsTitleBarVisibleProperty, ps, () => control.IsTitleBarVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleBarVisibilityOnFullScreen

/*ValueSetterGenerator*/
public static T TitleBarVisibilityOnFullScreen<T>(this T control, SukiUI.Controls.SukiWindow.TitleBarVisibilityMode value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.TitleBarVisibilityOnFullScreen = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleBarVisibilityOnFullScreen<T>(this T control, Func<SukiUI.Controls.SukiWindow.TitleBarVisibilityMode> func, Action<SukiUI.Controls.SukiWindow.TitleBarVisibilityMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarVisibilityOnFullScreenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleBarVisibilityOnFullScreen<T>(this T control,SukiUI.Controls.SukiWindow.TitleBarVisibilityMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleBarVisibilityOnFullScreenProperty, ps, () => control.TitleBarVisibilityOnFullScreen = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleBarVisibilityOnFullScreen<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarVisibilityOnFullScreenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleBarVisibilityOnFullScreen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarVisibilityOnFullScreenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleBarVisibilityOnFullScreen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Controls.SukiWindow.TitleBarVisibilityMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleBarVisibilityOnFullScreenProperty, ps, () => control.TitleBarVisibilityOnFullScreen = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleBarAutoHideDelay

/*ValueSetterGenerator*/
public static T TitleBarAutoHideDelay<T>(this T control, System.Int32 value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.TitleBarAutoHideDelay = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleBarAutoHideDelay<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarAutoHideDelayProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleBarAutoHideDelay<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleBarAutoHideDelayProperty, ps, () => control.TitleBarAutoHideDelay = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleBarAutoHideDelay<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarAutoHideDelayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleBarAutoHideDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarAutoHideDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleBarAutoHideDelay<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleBarAutoHideDelayProperty, ps, () => control.TitleBarAutoHideDelay = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleBarAutoShowDelay

/*ValueSetterGenerator*/
public static T TitleBarAutoShowDelay<T>(this T control, System.Int32 value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.TitleBarAutoShowDelay = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleBarAutoShowDelay<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarAutoShowDelayProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleBarAutoShowDelay<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleBarAutoShowDelayProperty, ps, () => control.TitleBarAutoShowDelay = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleBarAutoShowDelay<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarAutoShowDelayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleBarAutoShowDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarAutoShowDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleBarAutoShowDelay<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleBarAutoShowDelayProperty, ps, () => control.TitleBarAutoShowDelay = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleBarAnimationEnabled

/*ValueSetterGenerator*/
public static T TitleBarAnimationEnabled<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.TitleBarAnimationEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleBarAnimationEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarAnimationEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleBarAnimationEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleBarAnimationEnabledProperty, ps, () => control.TitleBarAnimationEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleBarAnimationEnabled<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarAnimationEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleBarAnimationEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarAnimationEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleBarAnimationEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleBarAnimationEnabledProperty, ps, () => control.TitleBarAnimationEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleFontSize

/*ValueSetterGenerator*/
public static T TitleFontSize<T>(this T control, System.Double value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.TitleFontSize = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleFontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleFontSizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleFontSize<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleFontSizeProperty, ps, () => control.TitleFontSize = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleFontSize<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleFontSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleFontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleFontSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleFontSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleFontSizeProperty, ps, () => control.TitleFontSize = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleFontWeight

/*ValueSetterGenerator*/
public static T TitleFontWeight<T>(this T control, Avalonia.Media.FontWeight value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.TitleFontWeight = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleFontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleFontWeightProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleFontWeight<T>(this T control,Avalonia.Media.FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleFontWeightProperty, ps, () => control.TitleFontWeight = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleFontWeight<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleFontWeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleFontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleFontWeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleFontWeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleFontWeightProperty, ps, () => control.TitleFontWeight = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleBarContextMenu

/*ValueSetterGenerator*/
public static T TitleBarContextMenu<T>(this T control, Avalonia.Controls.ContextMenu value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.TitleBarContextMenu = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleBarContextMenu<T>(this T control, Func<Avalonia.Controls.ContextMenu> func, Action<Avalonia.Controls.ContextMenu>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarContextMenuProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleBarContextMenu<T>(this T control,Avalonia.Controls.ContextMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleBarContextMenuProperty, ps, () => control.TitleBarContextMenu = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleBarContextMenu<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarContextMenuProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleBarContextMenu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.TitleBarContextMenuProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleBarContextMenu<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ContextMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.TitleBarContextMenuProperty, ps, () => control.TitleBarContextMenu = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LogoContent

/*ValueSetterGenerator*/
public static T LogoContent<T>(this T control, Avalonia.Controls.Control value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.LogoContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T LogoContent<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.LogoContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LogoContent<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.LogoContentProperty, ps, () => control.LogoContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LogoContent<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.LogoContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LogoContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.LogoContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LogoContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.LogoContentProperty, ps, () => control.LogoContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LogoDoubleTapClosesWindow

/*ValueSetterGenerator*/
public static T LogoDoubleTapClosesWindow<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.LogoDoubleTapClosesWindow = value!);

/*BindFromExpressionSetterGenerator*/
public static T LogoDoubleTapClosesWindow<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.LogoDoubleTapClosesWindowProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LogoDoubleTapClosesWindow<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.LogoDoubleTapClosesWindowProperty, ps, () => control.LogoDoubleTapClosesWindow = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LogoDoubleTapClosesWindow<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.LogoDoubleTapClosesWindowProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LogoDoubleTapClosesWindow<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.LogoDoubleTapClosesWindowProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LogoDoubleTapClosesWindow<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.LogoDoubleTapClosesWindowProperty, ps, () => control.LogoDoubleTapClosesWindow = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowBottomBorder

/*ValueSetterGenerator*/
public static T ShowBottomBorder<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.ShowBottomBorder = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowBottomBorder<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.ShowBottomBorderProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowBottomBorder<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.ShowBottomBorderProperty, ps, () => control.ShowBottomBorder = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowBottomBorder<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.ShowBottomBorderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowBottomBorder<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.ShowBottomBorderProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowBottomBorder<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.ShowBottomBorderProperty, ps, () => control.ShowBottomBorder = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsMenuVisible

/*ValueSetterGenerator*/
public static T IsMenuVisible<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.IsMenuVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsMenuVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.IsMenuVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsMenuVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.IsMenuVisibleProperty, ps, () => control.IsMenuVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsMenuVisible<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.IsMenuVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsMenuVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.IsMenuVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsMenuVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.IsMenuVisibleProperty, ps, () => control.IsMenuVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MenuItems

/*ValueSetterGenerator*/
public static T MenuItems<T>(this T control, Avalonia.Collections.AvaloniaList<Avalonia.Controls.MenuItem> value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.MenuItems = value!);

/*BindFromExpressionSetterGenerator*/
public static T MenuItems<T>(this T control, Func<Avalonia.Collections.AvaloniaList<Avalonia.Controls.MenuItem>> func, Action<Avalonia.Collections.AvaloniaList<Avalonia.Controls.MenuItem>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.MenuItemsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MenuItems<T>(this T control,Avalonia.Collections.AvaloniaList<Avalonia.Controls.MenuItem> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.MenuItemsProperty, ps, () => control.MenuItems = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MenuItems<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.MenuItemsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MenuItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.MenuItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MenuItems<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<Avalonia.Controls.MenuItem>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.MenuItemsProperty, ps, () => control.MenuItems = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // RootCornerRadius

/*ValueSetterGenerator*/
public static T RootCornerRadius<T>(this T control, Avalonia.CornerRadius value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.RootCornerRadius = value!);

/*BindFromExpressionSetterGenerator*/
public static T RootCornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.RootCornerRadiusProperty!, func, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T RootCornerRadius<T>(this T control, System.Double uniformRadius = default!) where T : SukiUI.Controls.SukiWindow 
   => control._set(() => control.RootCornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T RootCornerRadius<T>(this T control, System.Double top = default!, System.Double bottom = default!) where T : SukiUI.Controls.SukiWindow 
   => control._set(() => control.RootCornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T RootCornerRadius<T>(this T control, System.Double topLeft = default!, System.Double topRight = default!, System.Double bottomRight = default!, System.Double bottomLeft = default!) where T : SukiUI.Controls.SukiWindow 
   => control._set(() => control.RootCornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));

/*MagicalSetterGenerator*/
[Obsolete]
public static T RootCornerRadius<T>(this T control,Avalonia.CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.RootCornerRadiusProperty, ps, () => control.RootCornerRadius = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RootCornerRadius<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.RootCornerRadiusProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RootCornerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.RootCornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T RootCornerRadius<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.RootCornerRadiusProperty, ps, () => control.RootCornerRadius = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowTitlebarBackground

/*ValueSetterGenerator*/
public static T ShowTitlebarBackground<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.ShowTitlebarBackground = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowTitlebarBackground<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.ShowTitlebarBackgroundProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowTitlebarBackground<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.ShowTitlebarBackgroundProperty, ps, () => control.ShowTitlebarBackground = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowTitlebarBackground<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.ShowTitlebarBackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowTitlebarBackground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.ShowTitlebarBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowTitlebarBackground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.ShowTitlebarBackgroundProperty, ps, () => control.ShowTitlebarBackground = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CanFullScreen

/*ValueSetterGenerator*/
public static T CanFullScreen<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.CanFullScreen = value!);

/*BindFromExpressionSetterGenerator*/
public static T CanFullScreen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.CanFullScreenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CanFullScreen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.CanFullScreenProperty, ps, () => control.CanFullScreen = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanFullScreen<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.CanFullScreenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanFullScreen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.CanFullScreenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CanFullScreen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.CanFullScreenProperty, ps, () => control.CanFullScreen = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CanPin

/*ValueSetterGenerator*/
public static T CanPin<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.CanPin = value!);

/*BindFromExpressionSetterGenerator*/
public static T CanPin<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.CanPinProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CanPin<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.CanPinProperty, ps, () => control.CanPin = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanPin<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.CanPinProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanPin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.CanPinProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CanPin<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.CanPinProperty, ps, () => control.CanPin = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CanMove

/*ValueSetterGenerator*/
public static T CanMove<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.CanMove = value!);

/*BindFromExpressionSetterGenerator*/
public static T CanMove<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.CanMoveProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CanMove<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.CanMoveProperty, ps, () => control.CanMove = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanMove<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.CanMoveProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanMove<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.CanMoveProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CanMove<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.CanMoveProperty, ps, () => control.CanMove = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundAnimationEnabled

/*ValueSetterGenerator*/
public static T BackgroundAnimationEnabled<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.BackgroundAnimationEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundAnimationEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundAnimationEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundAnimationEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundAnimationEnabledProperty, ps, () => control.BackgroundAnimationEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundAnimationEnabled<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundAnimationEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundAnimationEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundAnimationEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundAnimationEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundAnimationEnabledProperty, ps, () => control.BackgroundAnimationEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundStyle

/*ValueSetterGenerator*/
public static T BackgroundStyle<T>(this T control, SukiUI.Enums.SukiBackgroundStyle value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.BackgroundStyle = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundStyle<T>(this T control, Func<SukiUI.Enums.SukiBackgroundStyle> func, Action<SukiUI.Enums.SukiBackgroundStyle>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundStyleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundStyle<T>(this T control,SukiUI.Enums.SukiBackgroundStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundStyleProperty, ps, () => control.BackgroundStyle = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundStyle<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundStyle<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Enums.SukiBackgroundStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundStyleProperty, ps, () => control.BackgroundStyle = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundShaderFile

/*ValueSetterGenerator*/
public static T BackgroundShaderFile<T>(this T control, System.String value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.BackgroundShaderFile = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundShaderFile<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundShaderFileProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundShaderFile<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundShaderFileProperty, ps, () => control.BackgroundShaderFile = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundShaderFile<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundShaderFileProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundShaderFile<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundShaderFileProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundShaderFile<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundShaderFileProperty, ps, () => control.BackgroundShaderFile = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundShaderCode

/*ValueSetterGenerator*/
public static T BackgroundShaderCode<T>(this T control, System.String value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.BackgroundShaderCode = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundShaderCode<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundShaderCodeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundShaderCode<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundShaderCodeProperty, ps, () => control.BackgroundShaderCode = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundShaderCode<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundShaderCodeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundShaderCode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundShaderCodeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundShaderCode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundShaderCodeProperty, ps, () => control.BackgroundShaderCode = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundTransitionsEnabled

/*ValueSetterGenerator*/
public static T BackgroundTransitionsEnabled<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.BackgroundTransitionsEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundTransitionsEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundTransitionsEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundTransitionsEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundTransitionsEnabledProperty, ps, () => control.BackgroundTransitionsEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundTransitionsEnabled<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundTransitionsEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundTransitionsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundTransitionsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundTransitionsEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundTransitionsEnabledProperty, ps, () => control.BackgroundTransitionsEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundTransitionTime

/*ValueSetterGenerator*/
public static T BackgroundTransitionTime<T>(this T control, System.Double value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.BackgroundTransitionTime = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundTransitionTime<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundTransitionTimeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundTransitionTime<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundTransitionTimeProperty, ps, () => control.BackgroundTransitionTime = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundTransitionTime<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundTransitionTimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundTransitionTime<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundTransitionTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundTransitionTime<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundTransitionTimeProperty, ps, () => control.BackgroundTransitionTime = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // BackgroundForceSoftwareRendering

/*ValueSetterGenerator*/
public static T BackgroundForceSoftwareRendering<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.BackgroundForceSoftwareRendering = value!);

/*BindFromExpressionSetterGenerator*/
public static T BackgroundForceSoftwareRendering<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundForceSoftwareRenderingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BackgroundForceSoftwareRendering<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundForceSoftwareRenderingProperty, ps, () => control.BackgroundForceSoftwareRendering = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundForceSoftwareRendering<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundForceSoftwareRenderingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundForceSoftwareRendering<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.BackgroundForceSoftwareRenderingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BackgroundForceSoftwareRendering<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.BackgroundForceSoftwareRenderingProperty, ps, () => control.BackgroundForceSoftwareRendering = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // RightWindowTitleBarControls

/*ValueSetterGenerator*/
public static T RightWindowTitleBarControls<T>(this T control, Avalonia.Controls.Controls value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.RightWindowTitleBarControls = value!);

/*BindFromExpressionSetterGenerator*/
public static T RightWindowTitleBarControls<T>(this T control, Func<Avalonia.Controls.Controls> func, Action<Avalonia.Controls.Controls>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.RightWindowTitleBarControlsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T RightWindowTitleBarControls<T>(this T control,Avalonia.Controls.Controls value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.RightWindowTitleBarControlsProperty, ps, () => control.RightWindowTitleBarControls = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RightWindowTitleBarControls<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.RightWindowTitleBarControlsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RightWindowTitleBarControls<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.RightWindowTitleBarControlsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T RightWindowTitleBarControls<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Controls> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.RightWindowTitleBarControlsProperty, ps, () => control.RightWindowTitleBarControls = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Hosts

/*ValueSetterGenerator*/
public static T Hosts<T>(this T control, Avalonia.Controls.Controls value) where T : SukiUI.Controls.SukiWindow 
=> control._set(() => control.Hosts = value!);

/*BindFromExpressionSetterGenerator*/
public static T Hosts<T>(this T control, Func<Avalonia.Controls.Controls> func, Action<Avalonia.Controls.Controls>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.HostsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Hosts<T>(this T control,Avalonia.Controls.Controls value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.HostsProperty, ps, () => control.Hosts = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Hosts<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.HostsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Hosts<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiWindow 
   => control._set(SukiUI.Controls.SukiWindow.HostsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Hosts<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Controls> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiWindow 
=> control._setEx(SukiUI.Controls.SukiWindow.HostsProperty, ps, () => control.Hosts = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // MaxWidthScreenRatio

/*ValueStyleSetterGenerator*/
public static Style<T> MaxWidthScreenRatio<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.MaxWidthScreenRatioProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxWidthScreenRatio<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.MaxWidthScreenRatioProperty, binding);


 // MaxHeightScreenRatio

/*ValueStyleSetterGenerator*/
public static Style<T> MaxHeightScreenRatio<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.MaxHeightScreenRatioProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxHeightScreenRatio<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.MaxHeightScreenRatioProperty, binding);


 // IsTitleBarVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsTitleBarVisible<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.IsTitleBarVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTitleBarVisible<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.IsTitleBarVisibleProperty, binding);


 // TitleBarVisibilityOnFullScreen

/*ValueStyleSetterGenerator*/
public static Style<T> TitleBarVisibilityOnFullScreen<T>(this Style<T> style, SukiUI.Controls.SukiWindow.TitleBarVisibilityMode value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleBarVisibilityOnFullScreenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleBarVisibilityOnFullScreen<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleBarVisibilityOnFullScreenProperty, binding);


 // TitleBarAutoHideDelay

/*ValueStyleSetterGenerator*/
public static Style<T> TitleBarAutoHideDelay<T>(this Style<T> style, System.Int32 value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleBarAutoHideDelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleBarAutoHideDelay<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleBarAutoHideDelayProperty, binding);


 // TitleBarAutoShowDelay

/*ValueStyleSetterGenerator*/
public static Style<T> TitleBarAutoShowDelay<T>(this Style<T> style, System.Int32 value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleBarAutoShowDelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleBarAutoShowDelay<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleBarAutoShowDelayProperty, binding);


 // TitleBarAnimationEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> TitleBarAnimationEnabled<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleBarAnimationEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleBarAnimationEnabled<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleBarAnimationEnabledProperty, binding);


 // TitleFontSize

/*ValueStyleSetterGenerator*/
public static Style<T> TitleFontSize<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleFontSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleFontSize<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleFontSizeProperty, binding);


 // TitleFontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> TitleFontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleFontWeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleFontWeight<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleFontWeightProperty, binding);


 // TitleBarContextMenu

/*ValueStyleSetterGenerator*/
public static Style<T> TitleBarContextMenu<T>(this Style<T> style, Avalonia.Controls.ContextMenu value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleBarContextMenuProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleBarContextMenu<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.TitleBarContextMenuProperty, binding);


 // LogoContent

/*ValueStyleSetterGenerator*/
public static Style<T> LogoContent<T>(this Style<T> style, Avalonia.Controls.Control value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.LogoContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LogoContent<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.LogoContentProperty, binding);


 // LogoDoubleTapClosesWindow

/*ValueStyleSetterGenerator*/
public static Style<T> LogoDoubleTapClosesWindow<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.LogoDoubleTapClosesWindowProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LogoDoubleTapClosesWindow<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.LogoDoubleTapClosesWindowProperty, binding);


 // ShowBottomBorder

/*ValueStyleSetterGenerator*/
public static Style<T> ShowBottomBorder<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.ShowBottomBorderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowBottomBorder<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.ShowBottomBorderProperty, binding);


 // IsMenuVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsMenuVisible<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.IsMenuVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsMenuVisible<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.IsMenuVisibleProperty, binding);


 // MenuItems

/*ValueStyleSetterGenerator*/
public static Style<T> MenuItems<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<Avalonia.Controls.MenuItem> value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.MenuItemsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MenuItems<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.MenuItemsProperty, binding);


 // RootCornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> RootCornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.RootCornerRadiusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RootCornerRadius<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.RootCornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> RootCornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : SukiUI.Controls.SukiWindow 
   => style._addSetter(SukiUI.Controls.SukiWindow.RootCornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> RootCornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : SukiUI.Controls.SukiWindow 
   => style._addSetter(SukiUI.Controls.SukiWindow.RootCornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> RootCornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : SukiUI.Controls.SukiWindow 
   => style._addSetter(SukiUI.Controls.SukiWindow.RootCornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // ShowTitlebarBackground

/*ValueStyleSetterGenerator*/
public static Style<T> ShowTitlebarBackground<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.ShowTitlebarBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowTitlebarBackground<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.ShowTitlebarBackgroundProperty, binding);


 // CanFullScreen

/*ValueStyleSetterGenerator*/
public static Style<T> CanFullScreen<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.CanFullScreenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanFullScreen<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.CanFullScreenProperty, binding);


 // CanPin

/*ValueStyleSetterGenerator*/
public static Style<T> CanPin<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.CanPinProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanPin<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.CanPinProperty, binding);


 // CanMove

/*ValueStyleSetterGenerator*/
public static Style<T> CanMove<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.CanMoveProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanMove<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.CanMoveProperty, binding);


 // BackgroundAnimationEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundAnimationEnabled<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundAnimationEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundAnimationEnabled<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundAnimationEnabledProperty, binding);


 // BackgroundStyle

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundStyle<T>(this Style<T> style, SukiUI.Enums.SukiBackgroundStyle value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundStyle<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundStyleProperty, binding);


 // BackgroundShaderFile

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundShaderFile<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundShaderFileProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundShaderFile<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundShaderFileProperty, binding);


 // BackgroundShaderCode

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundShaderCode<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundShaderCodeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundShaderCode<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundShaderCodeProperty, binding);


 // BackgroundTransitionsEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundTransitionsEnabled<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundTransitionsEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundTransitionsEnabled<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundTransitionsEnabledProperty, binding);


 // BackgroundTransitionTime

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundTransitionTime<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundTransitionTimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundTransitionTime<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundTransitionTimeProperty, binding);


 // BackgroundForceSoftwareRendering

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundForceSoftwareRendering<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundForceSoftwareRenderingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundForceSoftwareRendering<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.BackgroundForceSoftwareRenderingProperty, binding);


 // RightWindowTitleBarControls

/*ValueStyleSetterGenerator*/
public static Style<T> RightWindowTitleBarControls<T>(this Style<T> style, Avalonia.Controls.Controls value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.RightWindowTitleBarControlsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RightWindowTitleBarControls<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.RightWindowTitleBarControlsProperty, binding);


 // Hosts

/*ValueStyleSetterGenerator*/
public static Style<T> Hosts<T>(this Style<T> style, Avalonia.Controls.Controls value) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.HostsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Hosts<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiWindow 
=> style._addSetter(SukiUI.Controls.SukiWindow.HostsProperty, binding);



}
