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
public static partial class SukiToast_MarkupExtensions
{
//================= Properties ======================//
 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiToast 
=> control._set(() => control.Icon = value!);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.IconProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Icon<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.IconProperty, ps, () => control.Icon = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Icon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.IconProperty, ps, () => control.Icon = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DismissStartTimestamp

/*ValueSetterGenerator*/
public static T DismissStartTimestamp<T>(this T control, System.Double value) where T : SukiUI.Controls.SukiToast 
=> control._set(() => control.DismissStartTimestamp = value!);

/*BindFromExpressionSetterGenerator*/
public static T DismissStartTimestamp<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.DismissStartTimestampProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DismissStartTimestamp<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.DismissStartTimestampProperty, ps, () => control.DismissStartTimestamp = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DismissStartTimestamp<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.DismissStartTimestampProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DismissStartTimestamp<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.DismissStartTimestampProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DismissStartTimestamp<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.DismissStartTimestampProperty, ps, () => control.DismissStartTimestamp = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, System.String value) where T : SukiUI.Controls.SukiToast 
=> control._set(() => control.Title = value!);

/*BindFromExpressionSetterGenerator*/
public static T Title<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.TitleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Title<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.TitleProperty, ps, () => control.Title = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Title<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.TitleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Title<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.TitleProperty, ps, () => control.Title = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LoadingState

/*ValueSetterGenerator*/
public static T LoadingState<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiToast 
=> control._set(() => control.LoadingState = value!);

/*BindFromExpressionSetterGenerator*/
public static T LoadingState<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.LoadingStateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LoadingState<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.LoadingStateProperty, ps, () => control.LoadingState = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LoadingState<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.LoadingStateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LoadingState<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.LoadingStateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LoadingState<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.LoadingStateProperty, ps, () => control.LoadingState = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CanDismissByClicking

/*ValueSetterGenerator*/
public static T CanDismissByClicking<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiToast 
=> control._set(() => control.CanDismissByClicking = value!);

/*BindFromExpressionSetterGenerator*/
public static T CanDismissByClicking<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.CanDismissByClickingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CanDismissByClicking<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.CanDismissByClickingProperty, ps, () => control.CanDismissByClicking = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanDismissByClicking<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.CanDismissByClickingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanDismissByClicking<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.CanDismissByClickingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CanDismissByClicking<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.CanDismissByClickingProperty, ps, () => control.CanDismissByClicking = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CanDismissByTime

/*ValueSetterGenerator*/
public static T CanDismissByTime<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiToast 
=> control._set(() => control.CanDismissByTime = value!);

/*BindFromExpressionSetterGenerator*/
public static T CanDismissByTime<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.CanDismissByTimeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CanDismissByTime<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.CanDismissByTimeProperty, ps, () => control.CanDismissByTime = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanDismissByTime<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.CanDismissByTimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanDismissByTime<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.CanDismissByTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CanDismissByTime<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.CanDismissByTimeProperty, ps, () => control.CanDismissByTime = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DismissTimeout

/*ValueSetterGenerator*/
public static T DismissTimeout<T>(this T control, System.TimeSpan value) where T : SukiUI.Controls.SukiToast 
=> control._set(() => control.DismissTimeout = value!);

/*BindFromExpressionSetterGenerator*/
public static T DismissTimeout<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.DismissTimeoutProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DismissTimeout<T>(this T control,System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.DismissTimeoutProperty, ps, () => control.DismissTimeout = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DismissTimeout<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.DismissTimeoutProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DismissTimeout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.DismissTimeoutProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DismissTimeout<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.DismissTimeoutProperty, ps, () => control.DismissTimeout = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InterruptDismissTimerWhileHover

/*ValueSetterGenerator*/
public static T InterruptDismissTimerWhileHover<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiToast 
=> control._set(() => control.InterruptDismissTimerWhileHover = value!);

/*BindFromExpressionSetterGenerator*/
public static T InterruptDismissTimerWhileHover<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.InterruptDismissTimerWhileHoverProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InterruptDismissTimerWhileHover<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.InterruptDismissTimerWhileHoverProperty, ps, () => control.InterruptDismissTimerWhileHover = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InterruptDismissTimerWhileHover<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.InterruptDismissTimerWhileHoverProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InterruptDismissTimerWhileHover<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.InterruptDismissTimerWhileHoverProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InterruptDismissTimerWhileHover<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.InterruptDismissTimerWhileHoverProperty, ps, () => control.InterruptDismissTimerWhileHover = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DismissProgressValue

/*ValueSetterGenerator*/
public static T DismissProgressValue<T>(this T control, System.Double value) where T : SukiUI.Controls.SukiToast 
=> control._set(() => control.DismissProgressValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T DismissProgressValue<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.DismissProgressValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DismissProgressValue<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.DismissProgressValueProperty, ps, () => control.DismissProgressValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DismissProgressValue<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.DismissProgressValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DismissProgressValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.DismissProgressValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DismissProgressValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.DismissProgressValueProperty, ps, () => control.DismissProgressValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ActionButtons

/*ValueSetterGenerator*/
public static T ActionButtons<T>(this T control, System.Collections.ObjectModel.ObservableCollection<System.Object> value) where T : SukiUI.Controls.SukiToast 
=> control._set(() => control.ActionButtons = value!);

/*BindFromExpressionSetterGenerator*/
public static T ActionButtons<T>(this T control, Func<System.Collections.ObjectModel.ObservableCollection<System.Object>> func, Action<System.Collections.ObjectModel.ObservableCollection<System.Object>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.ActionButtonsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ActionButtons<T>(this T control,System.Collections.ObjectModel.ObservableCollection<System.Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.ActionButtonsProperty, ps, () => control.ActionButtons = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ActionButtons<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.ActionButtonsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ActionButtons<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToast 
   => control._set(SukiUI.Controls.SukiToast.ActionButtonsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ActionButtons<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.ObjectModel.ObservableCollection<System.Object>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToast 
=> control._setEx(SukiUI.Controls.SukiToast.ActionButtonsProperty, ps, () => control.ActionButtons = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.IconProperty, binding);


 // Title

/*ValueStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.TitleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.TitleProperty, binding);


 // LoadingState

/*ValueStyleSetterGenerator*/
public static Style<T> LoadingState<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.LoadingStateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LoadingState<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.LoadingStateProperty, binding);


 // CanDismissByClicking

/*ValueStyleSetterGenerator*/
public static Style<T> CanDismissByClicking<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.CanDismissByClickingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanDismissByClicking<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.CanDismissByClickingProperty, binding);


 // CanDismissByTime

/*ValueStyleSetterGenerator*/
public static Style<T> CanDismissByTime<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.CanDismissByTimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanDismissByTime<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.CanDismissByTimeProperty, binding);


 // InterruptDismissTimerWhileHover

/*ValueStyleSetterGenerator*/
public static Style<T> InterruptDismissTimerWhileHover<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.InterruptDismissTimerWhileHoverProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InterruptDismissTimerWhileHover<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiToast 
=> style._addSetter(SukiUI.Controls.SukiToast.InterruptDismissTimerWhileHoverProperty, binding);



}
