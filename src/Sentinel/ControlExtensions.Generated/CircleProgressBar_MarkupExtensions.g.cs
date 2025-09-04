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
public static partial class CircleProgressBar_MarkupExtensions
{
//================= Properties ======================//
 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Double value) where T : SukiUI.Controls.CircleProgressBar 
=> control._set(() => control.Value = value!);

/*BindFromExpressionSetterGenerator*/
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.CircleProgressBar 
   => control._set(SukiUI.Controls.CircleProgressBar.ValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Value<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.CircleProgressBar 
=> control._setEx(SukiUI.Controls.CircleProgressBar.ValueProperty, ps, () => control.Value = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Value<T>(this T control, IBinding binding) where T : SukiUI.Controls.CircleProgressBar 
   => control._set(SukiUI.Controls.CircleProgressBar.ValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.CircleProgressBar 
   => control._set(SukiUI.Controls.CircleProgressBar.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Value<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.CircleProgressBar 
=> control._setEx(SukiUI.Controls.CircleProgressBar.ValueProperty, ps, () => control.Value = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // StrokeWidth

/*ValueSetterGenerator*/
public static T StrokeWidth<T>(this T control, System.Double value) where T : SukiUI.Controls.CircleProgressBar 
=> control._set(() => control.StrokeWidth = value!);

/*BindFromExpressionSetterGenerator*/
public static T StrokeWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.CircleProgressBar 
   => control._set(SukiUI.Controls.CircleProgressBar.StrokeWidthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T StrokeWidth<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.CircleProgressBar 
=> control._setEx(SukiUI.Controls.CircleProgressBar.StrokeWidthProperty, ps, () => control.StrokeWidth = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeWidth<T>(this T control, IBinding binding) where T : SukiUI.Controls.CircleProgressBar 
   => control._set(SukiUI.Controls.CircleProgressBar.StrokeWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.CircleProgressBar 
   => control._set(SukiUI.Controls.CircleProgressBar.StrokeWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T StrokeWidth<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.CircleProgressBar 
=> control._setEx(SukiUI.Controls.CircleProgressBar.StrokeWidthProperty, ps, () => control.StrokeWidth = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsIndeterminate

/*ValueSetterGenerator*/
public static T IsIndeterminate<T>(this T control, System.Boolean value) where T : SukiUI.Controls.CircleProgressBar 
=> control._set(() => control.IsIndeterminate = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsIndeterminate<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.CircleProgressBar 
   => control._set(SukiUI.Controls.CircleProgressBar.IsIndeterminateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsIndeterminate<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.CircleProgressBar 
=> control._setEx(SukiUI.Controls.CircleProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsIndeterminate<T>(this T control, IBinding binding) where T : SukiUI.Controls.CircleProgressBar 
   => control._set(SukiUI.Controls.CircleProgressBar.IsIndeterminateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsIndeterminate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.CircleProgressBar 
   => control._set(SukiUI.Controls.CircleProgressBar.IsIndeterminateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsIndeterminate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.CircleProgressBar 
=> control._setEx(SukiUI.Controls.CircleProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.CircleProgressBar 
=> style._addSetter(SukiUI.Controls.CircleProgressBar.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.CircleProgressBar 
=> style._addSetter(SukiUI.Controls.CircleProgressBar.ValueProperty, binding);


 // StrokeWidth

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeWidth<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.CircleProgressBar 
=> style._addSetter(SukiUI.Controls.CircleProgressBar.StrokeWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeWidth<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.CircleProgressBar 
=> style._addSetter(SukiUI.Controls.CircleProgressBar.StrokeWidthProperty, binding);


 // IsIndeterminate

/*ValueStyleSetterGenerator*/
public static Style<T> IsIndeterminate<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.CircleProgressBar 
=> style._addSetter(SukiUI.Controls.CircleProgressBar.IsIndeterminateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsIndeterminate<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.CircleProgressBar 
=> style._addSetter(SukiUI.Controls.CircleProgressBar.IsIndeterminateProperty, binding);



}
